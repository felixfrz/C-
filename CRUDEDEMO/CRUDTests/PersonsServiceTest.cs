using AutoFixture;
using Entities;
using EntityFrameworkCoreMock;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using ServiceContracts;
using ServiceContracts.DTO;
using ServiceContracts.Enums;
using Services;
using System;
using Xunit.Abstractions;


namespace CRUDTests
{
    public class PersonsServiceTest
    {
        private readonly IPersonsService _personService;
        private readonly ICountriesService _countriesService;
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly IFixture _fixture;


        public PersonsServiceTest(ITestOutputHelper testOutputHelper)
        {
            _fixture = new Fixture();

            var countriesInitialData = new List<Country>() { };
            var personsInitialData = new List<Person>() { };
            DbContextMock<ApplicationDbContext> dbContextMock = new DbContextMock<ApplicationDbContext>(

                new DbContextOptionsBuilder<ApplicationDbContext>().Options
                );

            ApplicationDbContext dbContext = dbContextMock.Object;

            dbContextMock.CreateDbSetMock(temp => temp.Countries, countriesInitialData);

            dbContextMock.CreateDbSetMock(temp => temp.Persons, personsInitialData);

            _countriesService = new CountriesService(dbContext);



            _personService = new PersonsService(dbContext, _countriesService);

            _testOutputHelper = testOutputHelper;
        }


        #region AddPerson
        [Fact]
        public async Task AddPerson_NullPerson()
        {
            PersonAddRequest? personAddRequest = null;


            Func<Task> action = (async () =>
              {
                  await _personService.AddPerson(personAddRequest);
              });
            await action.Should().ThrowAsync<ArgumentNullException>();
            // await Assert.ThrowsAsync<ArgumentNullException>
        }

        [Fact]
        public async Task AddPerson_PersonNameIsNull()
        {
            PersonAddRequest? personAddRequest = _fixture.Build<PersonAddRequest>()
                .With(temp => temp.PersonName, null as string)
                .Create();

            Func<Task> action = (async () =>
            {
                await _personService.AddPerson(personAddRequest);
            });

            await action.Should().ThrowAsync<ArgumentException>();
        }

        [Fact]
        public async Task AddPerson_ProperPersonDetails()
        {

            //Arrange
            PersonAddRequest? personAddRequest = _fixture.Build<PersonAddRequest>()
                .With(temp => temp.Email, "someone@example.com")
                .Create();


            //Act
            PersonResponse person_response_from_add = await _personService.AddPerson(personAddRequest);

            List<PersonResponse> person_list = await _personService.GetAllPersons();


            //Assert
            //Assert.True(person_response_from_add.PersonID != Guid.Empty);
            person_response_from_add.PersonID.Should().NotBe(Guid.Empty);

            //Assert.Contains(person_response_from_add, person_list);

            person_list.Should().Contain(person_response_from_add);

        }

        #endregion

        #region GetPersonByPersonID

        [Fact]
        public async Task GetPersonByPersonID_NullPersonID()
        {
            Guid? personID = null;

            PersonResponse? person_response_from_get = await _personService.GetPersonByPersonID(personID);

            //Assert.Null(person_response_from_get);
            person_response_from_get.Should().BeNull();

        }


        [Fact]
        public async Task GetPersonByPersonID_WithPersonID()
        {
            CountryAddRequest country_request = _fixture.Build<CountryAddRequest>().Create();

            CountryResponse country_response = await _countriesService.AddCountry(country_request);

            PersonAddRequest person_request = _fixture.Build<PersonAddRequest>()
                .With(temp => temp.Email, "example@xyz.com")
                .Create();

            PersonResponse person_response_from_add = await _personService.AddPerson(person_request);

            PersonResponse? person_response_from_get = await _personService.GetPersonByPersonID(person_response_from_add.PersonID);


            //Assert.Equal(person_response_from_add, person_response_from_get);
            person_response_from_get.Should().Be(person_response_from_add);

        }
        #endregion

        #region GetAllPersons

        [Fact]
        public async Task GetAllPersons_EmptyList()
        {
            List<PersonResponse> persons_from_get = await _personService.GetAllPersons();

            //Assert.Empty(persons_from_get);
            persons_from_get.Should().BeEmpty();
        }


        [Fact]
        public async Task GetPersons_AddFewPersons()
        {
            CountryAddRequest country_request_1 = _fixture.Create<CountryAddRequest>();
            CountryAddRequest country_request_2 = _fixture.Create<CountryAddRequest>();

            CountryResponse country_response_1 = await _countriesService.AddCountry(country_request_1);
            CountryResponse country_response_2 = await _countriesService.AddCountry(country_request_2);

            PersonAddRequest person_request_1 = _fixture.Build<PersonAddRequest>()
                .With(temp => temp.Email, "ex@example.com")
                .Create();

            PersonAddRequest person_request_2 = _fixture.Build<PersonAddRequest>()
                .With(temp => temp.Email, "exam@example.com")
                .Create();

            PersonAddRequest person_request_3 = _fixture.Build<PersonAddRequest>()
                .With(temp => temp.Email, "example@example.com")
                .Create();

            List<PersonAddRequest> person_requests = new List<PersonAddRequest>() { person_request_1, person_request_2, person_request_3 };

            List<PersonResponse> person_response_list_from_add = new List<PersonResponse>();

            foreach (PersonAddRequest person_request in person_requests)
            {
                PersonResponse person_response = await _personService.AddPerson(person_request);

                person_response_list_from_add.Add(person_response);
            }

            _testOutputHelper.WriteLine("Expected: ");
            foreach (PersonResponse person_response_from_add in person_response_list_from_add)
            {
                _testOutputHelper.WriteLine(person_response_from_add.ToString());
            }

            List<PersonResponse> persons_list_from_get = await _personService.GetAllPersons();

            _testOutputHelper.WriteLine("Actual: ");
            foreach (PersonResponse person_response_from_get in persons_list_from_get)
            {
                _testOutputHelper.WriteLine(person_response_from_get.ToString());
            }


            //foreach (PersonResponse person_response_from_add in person_response_list_from_add)
            //{
            //    Assert.Contains(person_response_from_add, persons_list_from_get);

            //}
            persons_list_from_get.Should().BeEquivalentTo(person_response_list_from_add);
        }

        #endregion

        #region GetFilteredPersons

        [Fact]
        public async Task GetFilteredPersons_EmptySearchText()
        {
            CountryAddRequest country_request_1 = _fixture.Create<CountryAddRequest>();
            CountryAddRequest country_request_2 = _fixture.Create<CountryAddRequest>();

            CountryResponse country_response_1 = await _countriesService.AddCountry(country_request_1);
            CountryResponse country_response_2 = await _countriesService.AddCountry(country_request_2);

            PersonAddRequest person_request_1 = _fixture.Build<PersonAddRequest>()
                .With(temp => temp.Email, "ex@example.com")
                .Create();

            PersonAddRequest person_request_2 = _fixture.Build<PersonAddRequest>()
                .With(temp => temp.Email, "example@example.com")
                .Create();

            PersonAddRequest person_request_3 = _fixture.Build<PersonAddRequest>()
                .With(temp => temp.Email, "example1@example.com")
                .Create();

            List<PersonAddRequest> person_requests = new List<PersonAddRequest>() { person_request_1, person_request_2, person_request_3 };

            List<PersonResponse> person_response_list_from_add = new List<PersonResponse>();

            foreach (PersonAddRequest person_request in person_requests)
            {
                PersonResponse person_response = await _personService.AddPerson(person_request);

                person_response_list_from_add.Add(person_response);
            }

            _testOutputHelper.WriteLine("Expected: ");
            foreach (PersonResponse person_response_from_add in person_response_list_from_add)
            {
                _testOutputHelper.WriteLine(person_response_from_add.ToString());
            }

            List<PersonResponse> persons_list_from_search = await _personService.GetFilteredPersons(nameof(Person.PersonName), "");

            _testOutputHelper.WriteLine("Actual: ");
            foreach (PersonResponse person_response_from_get in persons_list_from_search)
            {
                _testOutputHelper.WriteLine(person_response_from_get.ToString());
            }


            //foreach (PersonResponse person_response_from_add in person_response_list_from_add)
            //{
            //    Assert.Contains(person_response_from_add, persons_list_from_search);
            //}

            persons_list_from_search.Should().BeEquivalentTo(person_response_list_from_add);
        }



        [Fact]
        public async Task GetFilteredPersons_SearchByPersonName()
        {
            CountryAddRequest country_request_1 = _fixture.Create<CountryAddRequest>();
            CountryAddRequest country_request_2 = _fixture.Create<CountryAddRequest>();

            CountryResponse country_response_1 = await _countriesService.AddCountry(country_request_1);
            CountryResponse country_response_2 = await _countriesService.AddCountry(country_request_2);

            PersonAddRequest person_request_1 = _fixture.Build<PersonAddRequest>()
                .With(temp => temp.PersonName, "Raham")
                .With(temp => temp.Email, "example@example.com")
                .With(temp => temp.CountryID, country_response_1.CountryID)
                .Create();

            PersonAddRequest person_request_2 = _fixture.Build<PersonAddRequest>()
                 .With(temp => temp.PersonName, "mary")
                .With(temp => temp.Email, "example3@example.com")
                .With(temp => temp.CountryID, country_response_1.CountryID)
                .Create();

            PersonAddRequest person_request_3 = _fixture.Build<PersonAddRequest>()
                .With(temp => temp.PersonName, "Rahams")
               .With(temp => temp.Email, "example5@example.com")
               .With(temp => temp.CountryID, country_response_2.CountryID)
               .Create();

            List<PersonAddRequest> person_requests = new List<PersonAddRequest>() { person_request_1, person_request_2, person_request_3 };

            List<PersonResponse> person_response_list_from_add = new List<PersonResponse>();

            foreach (PersonAddRequest person_request in person_requests)
            {
                PersonResponse person_response = await _personService.AddPerson(person_request);

                person_response_list_from_add.Add(person_response);
            }

            _testOutputHelper.WriteLine("Expected: ");
            foreach (PersonResponse person_response_from_add in person_response_list_from_add)
            {
                _testOutputHelper.WriteLine(person_response_from_add.ToString());
            }

            List<PersonResponse> persons_list_from_search = await _personService.GetFilteredPersons(nameof(Person.PersonName), "ma");

            _testOutputHelper.WriteLine("Actual: ");
            foreach (PersonResponse person_response_from_get in persons_list_from_search)
            {
                _testOutputHelper.WriteLine(person_response_from_get.ToString());
            }


            //foreach (PersonResponse person_response_from_add in person_response_list_from_add)
            //{
            //    if (person_response_from_add.PersonName != null)
            //    {
            //        if (person_response_from_add.PersonName.Contains("ma", StringComparison.OrdinalIgnoreCase))
            //        {
            //            Assert.Contains(person_response_from_add, persons_list_from_search);
            //        }
            //    }
            //}

            persons_list_from_search.Should().OnlyContain(temp => temp.PersonName.Contains("ma", StringComparison.OrdinalIgnoreCase));
        }
        #endregion

        #region GetSortedPersons
        [Fact]

        public async Task GetSortedPersons()
        {
            CountryAddRequest country_request_1 = _fixture.Create<CountryAddRequest>();
            CountryAddRequest country_request_2 = _fixture.Create<CountryAddRequest>();

            CountryResponse country_response_1 = await _countriesService.AddCountry(country_request_1);
            CountryResponse country_response_2 = await _countriesService.AddCountry(country_request_2);

            PersonAddRequest person_request_1 = _fixture.Build<PersonAddRequest>()
                .With(temp => temp.PersonName, "Raham")
                .With(temp => temp.Email, "example@example.com")
                .With(temp => temp.CountryID, country_response_1.CountryID)
                .Create();

            PersonAddRequest person_request_2 = _fixture.Build<PersonAddRequest>()
                 .With(temp => temp.PersonName, "Rahamw")
                .With(temp => temp.Email, "example3@example.com")
                .With(temp => temp.CountryID, country_response_1.CountryID)
                .Create();

            PersonAddRequest person_request_3 = _fixture.Build<PersonAddRequest>()
                .With(temp => temp.PersonName, "Rahams")
               .With(temp => temp.Email, "example5@example.com")
               .With(temp => temp.CountryID, country_response_2.CountryID)
               .Create();

            List<PersonAddRequest> person_requests = new List<PersonAddRequest>() { person_request_1, person_request_2, person_request_3 };

            List<PersonResponse> person_response_list_from_add = new List<PersonResponse>();

            foreach (PersonAddRequest person_request in person_requests)
            {
                PersonResponse person_response = await _personService.AddPerson(person_request);

                person_response_list_from_add.Add(person_response);
            }

            _testOutputHelper.WriteLine("Expected: ");
            foreach (PersonResponse person_response_from_add in person_response_list_from_add)
            {
                _testOutputHelper.WriteLine(person_response_from_add.ToString());
            }

            List<PersonResponse> allPersons = await _personService.GetAllPersons();

            List<PersonResponse> persons_list_from_sort = await _personService.GetSortedPersons(allPersons, nameof(Person.PersonName), SortOrderOptions.DESC);

            _testOutputHelper.WriteLine("Actual: ");
            foreach (PersonResponse person_response_from_get in persons_list_from_sort)
            {
                _testOutputHelper.WriteLine(person_response_from_get.ToString());
            }


            //person_response_list_from_add = person_response_list_from_add.OrderByDescending(temp => temp.PersonName).ToList();

            //for (int i = 0; i < person_response_list_from_add.Count; i++)
            //{
            //    Assert.Equal(person_response_list_from_add[i], persons_list_from_sort[i]);
            //}
            //persons_list_from_sort.Should().BeEquivalentTo(person_response_list_from_add);
            persons_list_from_sort.Should().BeInDescendingOrder(temp => temp.PersonName);

        }
        #endregion

        #region UpdatePerson

        [Fact]
        public async Task UpdatePerson_NullPerson()
        {
            PersonUpdateRequest? person_update_request = null;

            Func<Task> action = async () =>
             {
                 await _personService.UpdatePerson(person_update_request);
             };

            await action.Should().ThrowAsync<ArgumentNullException>();
        }

        [Fact]
        public async Task UpdatePerson_InvalidPersonID()
        {
            PersonUpdateRequest? person_update_request = _fixture.Build<PersonUpdateRequest>().Create();

            Func<Task> action = async () =>
             {
                 await _personService.UpdatePerson(person_update_request);
             };
            await action.Should().ThrowAsync<ArgumentException>();
        }


        [Fact]
        public async Task UpdatePerson_PersonNameIsNull()
        {

            CountryAddRequest country_add_request = _fixture.Create<CountryAddRequest>();

            CountryResponse country_response = await _countriesService.AddCountry(country_add_request);

            PersonAddRequest person_add_request = _fixture.Build<PersonAddRequest>()
                .With(temp => temp.PersonName, "Rahams")
               .With(temp => temp.Email, "example5@example.com")
               .With(temp => temp.CountryID, country_response.CountryID)
               .Create();

            PersonResponse person_response_from_add = await _personService.AddPerson(person_add_request);


            PersonUpdateRequest person_update_request = person_response_from_add.ToPersonUpdateRequest();

            person_update_request.PersonName = null;

            Func<Task> action = async () =>
             {
                 await _personService.UpdatePerson(person_update_request);
             };
            await action.Should().ThrowAsync<ArgumentException>();
        }




        [Fact]
        public async Task UpdatePerson_PersonFullDetailsUpdation()
        {

            CountryAddRequest country_add_request = _fixture.Create<CountryAddRequest>();

            CountryResponse country_response_from_add = await _countriesService.AddCountry(country_add_request);

            PersonAddRequest person_add_request = _fixture.Build<PersonAddRequest>()
                .With(temp => temp.Email, "example11@example.com")
                .Create();


            PersonResponse person_response_from_add = await _personService.AddPerson(person_add_request);


            PersonUpdateRequest person_update_request = person_response_from_add.ToPersonUpdateRequest();

            person_update_request.PersonName = "William";
            person_update_request.Email = "will@example.com";

            PersonResponse person_response_from_update = await _personService.UpdatePerson(person_update_request);

            PersonResponse? person_response_from_get = await _personService.GetPersonByPersonID(person_response_from_update.PersonID);

            //Assert.Equal(person_response_from_get, person_response_from_update);

            person_response_from_update.Should().Be(person_response_from_get);
        }

        #endregion

        #region DeletePerson
        [Fact]
        public async Task DeletePerson_ValidPersonID()
        {
            CountryAddRequest country_add_request = _fixture.Create<CountryAddRequest>();

            CountryResponse country_response_from_add = await _countriesService.AddCountry(country_add_request);


            PersonAddRequest person_add_request = _fixture.Build<PersonAddRequest>()
                .With(temp => temp.Email, "example11@example.com")
                .Create();

            PersonResponse person_response_from_add = await _personService.AddPerson(person_add_request);

            bool isDeleted = await _personService.DeletePerson(person_response_from_add.PersonID);

            //Assert.True(isDeleted);
            isDeleted.Should().BeTrue();

        }



        [Fact]
        public async Task DeletePerson_InvalidPersonID()
        {

            bool isDeleted = await _personService.DeletePerson(Guid.NewGuid());

            Assert.False(isDeleted);
            isDeleted.Should().BeFalse();

        }
        #endregion
    }
}

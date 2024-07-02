using ServiceContracts.DTO;
using ServiceContracts.Enums;
using System;


namespace ServiceContracts
{
    /// <summary>
    /// Represents business logic for manipulating Person entity
    /// </summary>
    public interface IPersonsService
    {

        /// <summary>
        /// Add a new person into the list of persons
        /// </summary>
        /// <param name="personAddRequest">person to add</param>
        /// <returns>Returns the same person details, along with newly generated PersonID</returns>
        Task<PersonResponse> AddPerson(PersonAddRequest? personAddRequest);

        /// <summary>
        /// Return all persons
        /// </summary>
        /// <returns>Returns a list of objects from PersonResponse type</returns>
        Task<List<PersonResponse>> GetAllPersons();

        /// <summary>
        /// Returns the person object based on the given person id
        /// </summary>
        /// <param name="personID">Person id to search</param>
        /// <returns>Returns matching person object</returns>
        Task<PersonResponse?> GetPersonByPersonID(Guid? personID);

        /// <summary>
        /// Returns all person objects that matches wit the
        /// </summary>
        /// <param name="searchBy"></param>
        /// <param name="searchString"></param>
        /// <returns></returns>
        Task<List<PersonResponse>> GetFilteredPersons(string searchBy, string? searchString);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="allPersons"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortOrder"></param>
        /// <returns></returns>
        Task<List<PersonResponse>> GetSortedPersons(List<PersonResponse> allPersons, string sortBy, SortOrderOptions sortOrder);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personUpdateRequest"></param>
        /// <returns></returns>
        Task<PersonResponse> UpdatePerson(PersonUpdateRequest? personUpdateRequest);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personID"></param>
        /// <returns></returns>
        Task<bool> DeletePerson(Guid? personID);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<MemoryStream> GetPersonsCSV();
    }
}

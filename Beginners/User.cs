using System;
namespace Beginners
{
    public class User
    {

        private string name;
        private int age;
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            set {

                if(value.Length > 1)
                {
                    name = value;
                }
        

            }
            get { return name; }
        }

        public int Age
        {
            set {

                age = value;

            }
            get {
                return age;
            }
        }
    }
}


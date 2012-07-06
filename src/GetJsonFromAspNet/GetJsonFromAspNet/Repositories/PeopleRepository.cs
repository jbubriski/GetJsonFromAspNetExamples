using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetJsonFromAspNet.Repositories
{
    public class PeopleRepository
    {
        public List<Person> GetPeople()
        {
            var people = new List<Person>();

            people.Add(new Person
            {
                Name = "Fry",
                Age = "28",
                Address = new Address
                {
                    State = "NY"
                }
            });

            people.Add(new Person
            {
                Name = "Leela",
                Age = "29",
                Address = new Address
                {
                    State = "NY"
                }
            });

            people.Add(new Person
            {
                Name = "Bender",
                Age = "30",
                Address = new Address
                {
                    State = "NY"
                }
            });

            return people;
        }

        public List<Dictionary<string, object>> GetPeopleDictionary()
        {
            var columnName = "Address";
            var people = new List<Dictionary<string, object>>();


            var person = new Dictionary<string, object>();

            person.Add("Name", "Fry");
            person.Add("Age", "28");
            person.Add(columnName, new Dictionary<string, string> { { "State", "NY" } });

            people.Add(person);


            person = new Dictionary<string, object>();

            person.Add("Name", "Leela");
            person.Add("Age", "29");
            person.Add(columnName, new Dictionary<string, string> { { "State", "NY" } });

            people.Add(person);


            person = new Dictionary<string, object>();

            person.Add("Name", "Bender");
            person.Add("Age", "30");
            person.Add(columnName, new Dictionary<string, string> { { "State", "NY" } });

            people.Add(person);

            return people;
        }
    }
}
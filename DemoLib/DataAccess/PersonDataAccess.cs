using PersonLib.Models;
using System.Collections.Generic;
using System.Linq;

namespace PersonLib
{
    public class PersonDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public PersonDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Frodo", LastName = "Baggins" });
            people.Add(new PersonModel { Id = 2, FirstName = "Peregrin", LastName = "Took" });
            people.Add(new PersonModel { Id = 3, FirstName = "Meriadoc", LastName = "Brandybuck" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel GetPerson(int id)
        {
            return people.FirstOrDefault(p => p.Id == id);
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new() { Id = people.Max(p => p.Id) + 1, FirstName = firstName, LastName = lastName };
            people.Add(p);
            return p;
        }
    }
}

using PersonLib.Models;
using System.Collections.Generic;

namespace PersonLib
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InsertPerson(string firstName, string lastName);
        PersonModel GetPerson(int id);
    }
}
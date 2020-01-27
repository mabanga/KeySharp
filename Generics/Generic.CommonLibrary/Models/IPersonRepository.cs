using System.Collections.Generic;

namespace Generic.CommonLibrary.Models
{
    public interface IPersonRepository
    {
        List<Person> AddPerson(Person newPerson);
        void DeletePerson(string lastname);
        List<Person> GetPeople();
        Person GetPerson(string lastname);
        void UpdatePerson(string lastname);
    }
}
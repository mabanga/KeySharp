using System.Collections.Generic;

namespace Generic.CommonLibrary.Models
{
    public class PersonRepository : IPersonRepository
    {
        FakeDatabase proxy = new FakeDatabase();

        public List<Person> GetPeople()
        {
            return proxy.GetGenericPeolple();
        }
        public Person GetPerson(string lastname)
        {
            return proxy.GetPerson(lastname);
        }
        public List<Person> AddPerson(Person newPerson)
        {
            return  proxy.AddPerson(newPerson);
        }
        public void UpdatePerson(string lastname)
        {
            proxy.UpdatePerson(lastname);
        }
        public void DeletePerson(string lastname)
        {
            proxy.DeletePerson(lastname);
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.CommonLibrary.Models
{
    public class GenericPerson : IRepository<Person, string>
    {
        FakeDatabase proxy = new FakeDatabase();

        public List<Person> AddItem(Person item)
        {
            return proxy.AddPerson(item);
        }

        public void DeleteItem(string key)
        {
            proxy.DeletePerson(key);
        }

        public Person GetItem(string key)
        {
            return proxy.GetPerson(key);
        }

        public List<Person> GetItems()
        {
            return proxy.GetGenericPeolple();
        }

        public void UpdateItem(string key)
        {
            proxy.UpdatePerson(key);
        }
    }
}

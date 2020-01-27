using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.CommonLibrary.Models
{
    public class FakeDatabase
    {
        private List<Person> copiedList = new List<Person>();

        List<Person> personlist = new List<Person>();

        public List<Person> GetGenericPeolple()
        {
            personlist.Add(new Person() { FirstName = "First1", Lastname = "Lastname1", Rating = 1, Startdate = new DateTime(1900, 01, 01) });
            personlist.Add(new Person() { FirstName = "First2", Lastname = "Lastname2", Rating = 2, Startdate = new DateTime(2000, 1, 1) });
            personlist.Add(new Person() { FirstName = "First3", Lastname = "Lastname3", Rating = 3, Startdate = new DateTime(2010, 1, 1) });
            personlist.Add(new Person() { FirstName = "First4", Lastname = "Lastname4", Rating = 4, Startdate = new DateTime(2020, 1, 1) });

            foreach (var item in personlist)
            {
                copiedList.Add(item);
            }
            return personlist;
        }
        public Person GetPerson(string lastname)
        {
            GetGenericPeolple();
            Person person = copiedList.Find(x => x.Lastname == lastname);
            return person;
        }
        public List<Person> AddPerson(Person newPerson)
        {
            GetGenericPeolple();
            personlist.Add(newPerson);
            return personlist;
        }
        public void UpdatePerson(string lastname)
        {
            int position = personlist.FindIndex(x => x.Lastname == lastname);
            personlist[position].Lastname = "New lastname";
        }
        public void DeletePerson(string lastname)
        {
            int position = personlist.FindIndex(x => x.Lastname == lastname);
            personlist.RemoveAt(position);
        }
        public List<Person>peopleGetAllPeople()
        {
            GetGenericPeolple();
            return copiedList;
        }
    }
}

using Generic.CommonLibrary.Models;
using System;
using System.Collections.Generic;

namespace WithoutRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peolpe = new FakeDatabase().GetGenericPeolple();
            List<Person> personlist = new FakeDatabase().GetGenericPeolple();


            Person Eric = new Person() { FirstName = "F", Lastname = "l", Startdate = new DateTime(1900, 01, 01) };
            //peolpe.Add(new Person() { FirstName = "Eric", Lastname = "Kunga", Rating = 5, Startdate = new DateTime() });
            //peolpe.Add(new Person() { FirstName = "Zekira", Lastname = "Mabanga", Rating = 6, Startdate = new DateTime() });
            //personlist.Add(new Person() { FirstName = "First1", Lastname = "Lastname1", Rating = 1, Startdate = new DateTime(1900,01,01) });
            //personlist.Add(new Person() { FirstName = "First2", Lastname = "Lastname2", Rating = 2, Startdate = new DateTime(2000,1,1) });
            //personlist.Add(new Person() { FirstName = "First3", Lastname = "Lastname3", Rating = 3, Startdate = new DateTime(2010,1,1) });
            //personlist.Add(new Person() { FirstName = "First4", Lastname = "Lastname4", Rating = 4, Startdate = new DateTime(2020,1,1) });

            //foreach (Person item in peolpe)
            //{
            //    Console.WriteLine(item.FirstName + "  " + item.Lastname + " " + item.Rating + " " + item.Startdate);
            //}
            //Console.WriteLine(new string('-', 10));
            //foreach (Person item in personlist)
            //{
            //    Console.WriteLine(item.FirstName + "  " + item.Lastname + " " + item.Rating + " " + item.Startdate);
            //}

            IPersonRepository repository = new PersonRepository();
            repository.AddPerson(new Person() { FirstName = "New first", Lastname = "New Last", Startdate = new DateTime(2012, 8, 14), Rating = 1000 });

            Console.WriteLine(new string('-', 10));
            Console.WriteLine("Get People");
            Console.WriteLine(new string('-', 10));

            var repo = repository.GetPeople();
            foreach (Person item in repo)
            {
                Console.WriteLine("Firstname: " + item.FirstName + " - Lastname: " + item.Lastname + " - Rating: " + item.Rating + " - Startdate" + item.Startdate);
            }
            Console.WriteLine(new string('-', 10));
            Console.WriteLine("Get Person");
            Console.WriteLine(new string('-', 10));

            var repoperson =repository.GetPerson("Lastname1");
            Console.WriteLine("Firstname: " + repoperson.FirstName + " - Lastname: " + repoperson.Lastname + " - Rating: " + repoperson.Rating + " - Startdate" + repoperson.Startdate);

            repoperson = repository.GetPerson("Lastname4");
            Console.WriteLine("Firstname: " + repoperson.FirstName + " - Lastname: " + repoperson.Lastname + " - Rating: " + repoperson.Rating + " - Startdate" + repoperson.Startdate);


            Console.WriteLine(" ");
            Console.WriteLine(new string('-', 10));


            IRepository<Person, string> Joran = new GenericPerson();

            List<Person> people = Joran.AddItem(Eric);


            foreach (var item in people)
            {
                //////Console.WriteLine("Firstname: " + item.FirstName + " - Lastname: " + item.Lastname + " - Rating: " + item.Rating + " - Startdate" + item.Startdate);
            }
            //Show();
            Console.ReadKey();
        }
        //static void Show()
        //{
        //    var repo = new FakeDatabase();
        //    var people = repo.peopleGetAllPeople();
        //    foreach (var item in repo)
        //    {
        //        Console.WriteLine("Firstname: " + item.FirstName + " - Lastname: " + item.Lastname + " - Rating: " + item.Rating + " - Startdate" + item.Startdate);

        //    }
        //}
    }
}

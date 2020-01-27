using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableMethod
{
    public class People
    {
        Person[] people = new Person[]
        {
            new Person{Name="Person1", Age=15},
            new Person{Name="Person2", Age=25},
            new Person{Name="Person3", Age=35},
            new Person{Name="Person4", Age=45},
            new Person{Name="Person5", Age=55},
        };

        public IEnumerable<Person> GetPeople()
        {
            return people;
        }
    }
}

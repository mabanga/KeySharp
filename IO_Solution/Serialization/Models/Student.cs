using System;

namespace Serialization.Models
{
    [Serializable]
    public class Student
    {
        [NonSerialized]
        public string Address;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


}

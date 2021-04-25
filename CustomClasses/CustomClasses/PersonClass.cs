using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClasses
{
    class PersonClass
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        private string firstName = ""; //Backing Field
        public string FirstName
        {
            get
        {
            return firstName;
        }
            set
        {
        if (value == null)
        throw new ArgumentOutOfRangeException("FirstName",
        "Person.FirstName cannot be null.");

        if (value.Length < 1)
        throw new ArgumentOutOfRangeException("FirstName",
        "Person.FirstName cannot be blank.");
            }
        }
    }
}

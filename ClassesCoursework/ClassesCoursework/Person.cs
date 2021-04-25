using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesCoursework
{
    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }

        //Display the persons address
        //A real application might print this on an envelope
        public string getAddress()
        {
            return firstName + "" + lastName
            + "\n" + street + "\n" + city +
            "" + state + "" + zip;
        }

    }
}

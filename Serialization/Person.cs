using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person()
        {
        }

        public Person(int nPersonId, string sFirstName, string sLastName, int nAge)
        {
            PersonId = nPersonId;
            FirstName = sFirstName;
            LastName = sLastName;
            Age = nAge;
        }
    }
}

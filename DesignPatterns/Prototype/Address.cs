using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Address
    {
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

        public Address(string state,string country,string zip)
        {
            State = state;
            Country = country;
            ZipCode = zip;
        }
    }
}

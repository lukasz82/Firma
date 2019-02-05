using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string ZIPcode { get; set; }

        public Address(string city, string street, string zipCode)
        {
            City = city;
            Street = street;
            ZIPcode = zipCode;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Test
{
    public class Address
    {
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }

        public string FullAddress()
        {
            return $"{Street} {HouseNumber}\n" +
                    $"{PostalCode} {City} ";


        }
    }
}
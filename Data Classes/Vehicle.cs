using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Test
{
    public abstract class Vehicle
    {

        public abstract string Brand { get; set; }

        public abstract string Model { get; set; }

        public abstract int Tires { get; set; }

        public abstract string Color { get; set; }

        public abstract int? Doors { get; set; }

        public abstract DateTime ManufactureDate { get; set; }


        public abstract string GetCarDetails();



    }
}
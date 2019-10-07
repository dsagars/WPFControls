using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;
namespace Test

{
    public class Car : Vehicle
    {
        public override string Brand { get; set; }

        public override string Model { get; set; }

        public override string Color { get; set; }

        public override int Tires { get; set; }

        public override int? Doors { get; set; }

        public override DateTime ManufactureDate { get; set; }

        public override string GetCarDetails()
        {
            return $"Brand  : {Brand}\n" +
                   $"Model : {Model}\n" +
                   $"Color : {Color}\n" +
                   $"Tires : {Tires}\n" +
                   $"Doors : {Doors}\n" +
                   $"MFD : {ManufactureDate}\n";
        }
       
       

    }


}
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;
namespace Test

{
    public class Car 
    {
        public  string Brand { get; set; }

        public  string Model { get; set; }

        public  string Color { get; set; }

        public  int Tires { get; set; }

        public int? Doors { get; set; }

        public  DateTime ManufactureDate { get; set; }

        public  string GetCarDetails()
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
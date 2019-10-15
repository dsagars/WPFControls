using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;
namespace Test

{
    public class Car : BindableBase
    {
        private string brand;
        private string model;
        private string color;
        private int tires;
        private int? doors;
        private DateTime manufactureDate;
        
        public  string Brand
        {
            get { return brand; }
            set
            {
                brand = value;
                NotifyPropertyChanged("Brand");
            }
        }

        public  string Model
        {
            get { return model; }
            set
            {
                model = value;
                NotifyPropertyChanged("Model");
            }
        }

        public  string Color
        {
            get { return color; }
            set
            {
                color = value;
                NotifyPropertyChanged("Color");
            }
        }

        public  int Tires
        {
            get { return tires; }
            set
            {
                tires = value;
                NotifyPropertyChanged("Tires");
            }
        }

        public int? Doors
        {
            get { return doors; }
            set
            {
                doors = value;
                NotifyPropertyChanged("Doors");
            }
        }

        public  DateTime ManufactureDate
        {
            get { return manufactureDate; }
            set
            {
                manufactureDate = value;
                NotifyPropertyChanged("ManufactureDate");
            }
        }
        public  string GetCarDetails()
        {
            return $"Brand  : {Brand}\n" +
                   $"Model : {Model}\n" +
                   $"Color : {Color}\n" +
                   $"Tires : {Tires}\n" +
                   $"Doors : {Doors}\n" +
                   $"MFD : {ManufactureDate}\n";
        }
        public string DemoCar
        {
            get
            {
                return 
                   $"Brand  : {Brand}\n" +
                   $"Model : {Model}\n" +
                   $"Color : {Color}\n" +
                   $"Tires : {Tires}\n" +
                   $"Doors : {Doors}\n" +
                   $"MFD : {ManufactureDate}\n";
                       
            }
            set
            {
                DemoCar = value; 
            }

        }


    }


}
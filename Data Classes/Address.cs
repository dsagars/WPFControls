using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Test
{
    public class Address : BindableBase
    {
        private string street;
        private int houseNumber;
        private int postalcode;
        private string city;
        public string Street
        {
            get { return street; }
            set
            {
                street = value;
                NotifyPropertyChanged("Street");
            }
        }
        public int HouseNumber
        {
            get { return houseNumber; }
            set
            {
                houseNumber = value;
                NotifyPropertyChanged("HouseNumber");
            }
        }
        public int PostalCode
        {
            get { return postalcode; }
            set
            {
                postalcode = value;
                NotifyPropertyChanged("PostalCode");
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                city = value;
                NotifyPropertyChanged("City");
            }
        }

        public string FullAddress()
        {
            return $"{Street} {HouseNumber}\n" +
                    $"{PostalCode} {City} ";


        }
        public string DemoAddress
        {
            get
            {
                return $"{Street} {HouseNumber} \n" +
                       $"{PostalCode} {City}";
            }

        }
    }
}
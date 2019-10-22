using System.Collections.Generic;

namespace Test
{
    public class CompanyData
    {
        public string name { get; set; }

        public bool isMainCompany { get; set; }
        public CompanyAddress address { get; set; }
        public List<CompanyCar> cars { get; set; }
        public CompanyData(string name, bool isMainCompany, CompanyAddress address, List<CompanyCar> cars)
        {
            this.name = name;
            this.isMainCompany = isMainCompany;
            this.address = address;
            this.cars = cars;
        }
    }

    public class CompanyCar
    {
        public string name { get; set; }

        public CompanyCar(string name)
        {
            this.name = name;
        }
    }

    public class CompanyAddress
    {
        public string street { get; set; }

        public int number { get; set; }

        public CompanyAddress(string s, int n)
        {
            this.street = s;
            this.number = n;
        }

        public string DisplayAddress { get { return street + " " + number; } }
    }
}
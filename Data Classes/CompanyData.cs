using System.Collections.Generic;

namespace Test
{
    public class CompanyData
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }

        public bool IsMainCompany { get; set; }
        public CompanyAddress Address { get; set; }
        public List<CompanyCar> Cars { get; set; }
        public CompanyData(int id,string name, bool isMainCompany, CompanyAddress address, List<CompanyCar> cars)
        {
            this.CompanyName = name;
            this.IsMainCompany = isMainCompany;
            this.Address = address;
            this.Cars = cars;
            this.Id = id;
        }
    }

    public class CompanyCar
    {
        public string Brand { get; set; }

        public CompanyCar(string brand)
        {
            this.Brand = brand;
        }
    }

    public class CompanyAddress
    {
        public string Street { get; set; }

        public int Number { get; set; }

        public CompanyAddress(string s, int n)
        {
            this.Street = s;
            this.Number = n;
        }

        public string DisplayAddress { get { return Street + " " + Number; } }
    }
}
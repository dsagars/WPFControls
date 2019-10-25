using System.Collections.Generic;
using System.ComponentModel;

namespace Test
{
    public class CompanyData : INotifyPropertyChanged
    {
        private string companyName;
        private bool isMainCompany;
        public string CompanyName
        {
            get { return companyName; }
            set { SetField(ref companyName, value, "CompanyName");}
        }

        public bool IsMainCompany
        {
            get { return isMainCompany; }
            set { SetField(ref isMainCompany, value, "IsMainCompany"); }
        }
        public CompanyAddress address { get; set; }
        public List<CompanyCar> cars { get; set; }
        public CompanyData(string name, bool isMainCompany, CompanyAddress address, List<CompanyCar> cars)
        {
            this.CompanyName = name;
            this.IsMainCompany = isMainCompany;
            this.address = address;
            this.cars = cars;
           
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
        protected bool SetField<CompanyData>(ref CompanyData field, CompanyData value, string propertyName)
        {
            if (EqualityComparer<CompanyData>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
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

        public string Display { get { return street + " " + number; } }
    }
}
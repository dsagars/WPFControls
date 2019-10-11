using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Test
{
    public class Company : ICorporation
    {
        public string companyName;
        public List<Car> cars;
        public List<Address> companyAddress;
        public bool isMainCompany;
 
        public virtual string CompanyName
        {
            get { return companyName; }
            set
            {
                if(this.companyName != value)
                {
                    this.companyName = value;
                    this.NotifyPropertyChanged("CompanyName");
                }
            }
        }
         
        public virtual List<Car> Cars { get; set; }
       
        public virtual bool IsMainCompany
        {
            get { return this.isMainCompany; }
            set
            {
                if(this.isMainCompany != value)
                {
                    this.isMainCompany = value;
                    this.NotifyPropertyChanged("IsMainCompany");
                }
            }
        }
        public List<Address> CompanyAddress { get; set; }
       
        public virtual string CompanyDetail()
        {
            return $"CompanyName  : {CompanyName}\n" +
                   $"IsMainCompany: {IsMainCompany}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged( string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
               
        }
    }
}

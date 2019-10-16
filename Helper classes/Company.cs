using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Test
{
    public class Company : BindableBase, ICorporation
    {
        public string companyName;
        public ObservableCollection<Car> cars;
        public bool isMainCompany;
        public ObservableCollection<Address> companyAddress;

        
        public virtual string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
                NotifyPropertyChanged("CompanyName");
            }

        }
       
        
        public virtual ObservableCollection<Car> Cars
        {
            get
            {
                return cars;
            }
            set
            {    
            
                cars = value;
                NotifyPropertyChanged("Cars");
            }
        }        
        public virtual bool IsMainCompany
        {
            get
            {
                return isMainCompany;
            }
            set
            {
                isMainCompany = value;
                NotifyPropertyChanged("IsMainCompany");
            }
        }
        
        public ObservableCollection<Address> CompanyAddress
        {
            get
            {
                return companyAddress;
            }
            set
            {
                companyAddress = value;
                NotifyPropertyChanged("CompanyAddress");
            }
        }
        public virtual string CompanyDetail()
        {
            return $"CompanyName  : {CompanyName}\n" +
                   $"IsMainCompany: {IsMainCompany}";
                    
        }

       
    }
}

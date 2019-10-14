using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Test
{
    public class Company : ICorporation, INotifyPropertyChanged
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
                if(value == companyName)
                {
                    return;
                }
                companyName = value;
                OnPropertyChanged();
                
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
                if(value == cars)
                {
                    return;
                }
                cars = value;
                OnPropertyChanged();
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
                if(value == isMainCompany)
                {
                    return;
                }
                isMainCompany = value;
                OnPropertyChanged();
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
                if(value == companyAddress)
                {
                    return;
                }
                companyAddress = value;
                OnPropertyChanged();
            }
        }
        public virtual string CompanyDetail()
        {
            return $"CompanyName  : {CompanyName}\n" +
                   $"IsMainCompany: {IsMainCompany}";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propetyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("propertyName"));
        }


    }
}

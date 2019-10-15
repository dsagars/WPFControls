using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Test
{
    public partial class MainWindow : Window, INotifyCollectionChanged, INotifyPropertyChanged
    {
        private ObservableCollection<Company> Companies;
        private ObservableCollection<Car> CarsToAdd;
        private ObservableCollection<Address> AddressToAdd;
        private ObservableCollection<Company> ModifiedCompanyList;
        public MainWindow()
        {
            InitializeComponent();
            Companies = new ObservableCollection<Company>();

            CarsToAdd = new ObservableCollection<Car>();
            AddressToAdd = new ObservableCollection<Address>();
            ModifiedCompanyList = new ObservableCollection<Company>();
            DataContext = Companies;
            Companies.CollectionChanged += this.CollectionChanged;
        }



        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            CarsToAdd.Add(new Car
            {
                Brand = txtBrand.Text,
                Model = txtModel.Text,
                Color = txtColor.Text,
                Doors = int.Parse(txtDoors.Text),
                Tires = int.Parse(txtTires.Text),
                ManufactureDate = DateTime.Parse(txtMFD.Text)
            });

            AddressToAdd.Add(new Address
            {
                Street = txtStreet.Text,
                HouseNumber = int.Parse(txtHouseNumber.Text),
                PostalCode = int.Parse(txtPostalCode.Text),
                City = txtCity.Text
            });

            Companies.Add(new Company
            {

                CompanyName = txtCompanyName.Text,
                IsMainCompany = bool.Parse(txtIsMainCompany.Text),
                Cars = CarsToAdd,
                CompanyAddress = AddressToAdd

            });


            txtBrand.Text = txtModel.Text
          = txtColor.Text = txtDoors.Text
          = txtTires.Text = txtStreet.Text
          = txtHouseNumber.Text = txtPostalCode.Text
          = txtPostalCode.Text = txtCity.Text
          = txtCompanyName.Text = txtIsMainCompany.Text
          = txtMFD.Text = string.Empty;

        }


        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            Companies.Remove(listCompany.SelectedItem as Company);
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Company company in e.NewItems)
                {
                    ModifiedCompanyList.Add(company);
                    company.PropertyChanged += this.OnItemPropertyChanged;
                }
            }
            if (e.OldItems != null)
            {
                foreach (Company company in e.OldItems)
                {
                    ModifiedCompanyList.Add(company);
                    company.PropertyChanged -= this.OnItemPropertyChanged;
                }
            }
        }

        public void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Company company = sender as Company;
            if (company != null)
            {
                ModifiedCompanyList.Add(company);
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (SelectCompany.SelectedItem.ToString() != null)
            {
                Company company = new Company(); 
                if(SelectCompany.SelectedItem.ToString() == company.CompanyName)
                {
                    txtCompanyName.IsEnabled = false;
                    txtIsMainCompany.IsEnabled = false;
                    MessageBox.Show(company.CompanyName);
                }
            }
        }
        private void ComboBoxSelectionChanged(object sender, EventArgs e)
        {
            if (SelectCompany.SelectedItem.ToString() != null)
            {
                txtCompanyName.IsEnabled = false;
            }
        }

        
    }
}

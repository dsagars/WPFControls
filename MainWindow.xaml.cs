using System;
using System.Collections;
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
        private Company myCompany;
        private ObservableCollection<Car> CarsToAdd;
        private ObservableCollection<Address> AddressToAdd;
        private ObservableCollection<Company> ModifiedCompanyList;
        public MainWindow()
        {
            InitializeComponent();
            myCompany = new Company();

            CarsToAdd = new ObservableCollection<Car>();
            AddressToAdd = new ObservableCollection<Address>();
            ModifiedCompanyList = new ObservableCollection<Company>();
            DataContext = ModifiedCompanyList;
            listViewCompany.ItemsSource = ModifiedCompanyList;
            ModifiedCompanyList.CollectionChanged += this.OnCollectionChanged;
            
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

            /*Companies.Add(new Company
            {

                CompanyName = txtCompanyName.Text,
                IsMainCompany = bool.Parse(txtIsMainCompany.Text),
                Cars = CarsToAdd,
                CompanyAddress = AddressToAdd

            });*/
            myCompany = new Company()
            {
                CompanyName = txtCompanyName.Text,
                IsMainCompany = bool.Parse(txtIsMainCompany.Text),
                Cars = CarsToAdd,
                CompanyAddress = AddressToAdd
            };

            ModifiedCompanyList.Add(myCompany);


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
            ModifiedCompanyList.Remove(listViewCompany.SelectedItem as Company);
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            EnterData enterData = new EnterData();
            enterData.DataContext = ModifiedCompanyList;
            enterData.Show();
           
        }


        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Company company in e.NewItems)
                {   
                    company.PropertyChanged += this.OnItemPropertyChanged;
                }
            }
            if (e.OldItems != null)
            {
                foreach (Company company in e.OldItems)
                {
                    company.PropertyChanged -= this.OnItemPropertyChanged;
                }
            }
        }

        public virtual void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Company company = sender as Company;
            if (company != null)
            {
                ModifiedCompanyList.Add(company);
            }
        }



        private void SelectCompany_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (Company company in ModifiedCompanyList)
            {
                SelectCompany.ItemsSource = company.CompanyName;
                if (SelectCompany.SelectedItem.ToString() == company.CompanyName)
                {
                    btnEdit.DataContext = SelectCompany.SelectedItem;
                }
            }
        }
        
    }  
}

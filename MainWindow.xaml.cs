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
using Test;
namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Car> Cars;

        public List<Address> Addresses;
        public List<Company> Companies;


        /* public void allCarData(List<Car> carList)
         {
             carList = new List<Car>()
             {
                  new Car() { Brand = "Audi", Color = "Red", Model = "Coupe", Doors = 4, Tires = 4, ManufactureDate = new DateTime(2016, 02, 16) },
                  new Car() { Brand = "BMW", Color = "Red", Model = "Coupe", Doors = 4, Tires = 4, ManufactureDate = new DateTime(2016, 02, 16) },
                  new Car() { Brand = "Opel", Color = "Red", Model = "Coupe", Doors = 4, Tires = 4, ManufactureDate = new DateTime(2016, 02, 16) },
                  new Car() { Brand = "Mercedes", Color = "Red", Model = "Coupe", Doors = 4, Tires = 4, ManufactureDate = new DateTime(2016, 02, 16)}
             };
         }
         public void allAddressData(List<Address> addresses)
         {
             addresses = new List<Address>();
             var address1 = new Address() { Street = "Frankenstr", HouseNumber = 12, PostalCode = 20097, City = "Hamburg" };
             var address2 = new Address() { Street = "Hauptstr.", HouseNumber = 4, PostalCode = 20095, City = "Hamburg" };


         }
         public void allCompanyData(List<Company> companies)
         {
             companies = new List<Company>()
             {
                 new Company(){ Name = "Hsoft", IsMainCompany = true, CompanyAddress = new List<Address>(){ }, Cars = new List<Car>(){}},
                 new Company(){Name = "CFM", IsMainCompany = false, CompanyAddress = new List<Address>(){}, Cars = new List<Car>(){}}

             };
         }*/

        public MainWindow()
        {
            Cars = new List<Car>()
            {
                 new Car() { Brand = "Audi", Color = "Red", Model = "Coupe", Doors = 4, Tires = 4, ManufactureDate = new DateTime(2016, 02, 16) },
                 new Car() { Brand = "BMW", Color = "Red", Model = "Coupe", Doors = 4, Tires = 4, ManufactureDate = new DateTime(2016, 02, 16) },
                 new Car() { Brand = "Opel", Color = "Red", Model = "Coupe", Doors = 4, Tires = 4, ManufactureDate = new DateTime(2016, 02, 16) },
                 new Car() { Brand = "Mercedes", Color = "Red", Model = "Coupe", Doors = 4, Tires = 4, ManufactureDate = new DateTime(2016, 02, 16)}
            };

            Addresses = new List<Address>()
            {
             new Address(){Street = "Frankenstr", HouseNumber = 12, PostalCode = 20097, City = "Hamburg"},
             new Address(){ Street = "Hauptstr.", HouseNumber = 4, PostalCode = 20095, City = "Hamburg" }
            };
            Companies = new List<Company>()
            {
                 new Company(){ Name = "Hsoft", IsMainCompany = true, CompanyAddress = Addresses, Cars = Cars},
                 new Company(){Name = "CFM", IsMainCompany = false, CompanyAddress = new List<Address>(){}, Cars = new List<Car>(){}}
            };

           
            InitializeComponent();

        }


        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            foreach(Company company in Companies)
            {
               
                if(company.IsMainCompany == true)
                {
                    MessageBox.Show(company.Name);
                    foreach (Car car in Companies[0].Cars)
                    {
                        MessageBox.Show(car.GetCarDetails());
                    }
                }
            }
              
          
        }
    }
    }


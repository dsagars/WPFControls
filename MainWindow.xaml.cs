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
using System.IO;

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

       

        public MainWindow()
        {
            /*Cars = new List<Car>();
            Car car1 = new Car() { Brand = "Audi", Model = "A8", Color = "Red", Doors = 2, Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) };
            Car car2 = new Car() { Brand = "BMW", Model = "coupe", Color = "Blue", Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) };
            Car car3 = new Car() { Brand = "Opel", Model = "Astra", Color = "Black", Doors = 2, Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) };
            Car car4 = new Car() { Brand = "Mercedes", Model = "Benz", Color = "Black", Doors = 4, Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) };


            Addresses = new List<Address>();
            Address addressMainCompany = new Address() { Street = "Frankenstr.", HouseNumber = 12, PostalCode = 22111, City = "Hamburg" };
            Address addressSubCompany = new Address() { Street = "Mönckebergstr.", HouseNumber = 1, PostalCode = 20095, City = "Hamburg" };


            Companies = new List<Company>()
            {
                 new Company(){ Name = "Hsoft", IsMainCompany = true, CompanyAddress = new List<Address>(){ addressMainCompany} , Cars = new List<Car>(){car1,car2,car3 } },
                 new Company(){Name = "CFM", IsMainCompany = false, CompanyAddress = new List<Address>(){addressSubCompany} , Cars = new List<Car>(){car2, car4}}
            };
            */



            EnterData enterData = new EnterData();
            InitializeComponent();
            
          /*List<Car> Cars = new List<Car>()
            {
              new Car() { Brand = "Audi", Model = "A8", Color = "Red", Doors = 2, Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) },
              new Car() { Brand = "Audi", Model = "A8", Color = "Red", Doors = 2, Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) },
              new Car() { Brand = "Audi", Model = "A8", Color = "Red", Doors = 2, Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) },
              new Car() { Brand = "Audi", Model = "A8", Color = "Red", Doors = 2, Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) },

            };*/
             datagrid1.DataContext = Cars;
        }
      
        

         private void Btn1_Click(object sender, RoutedEventArgs e)
         {
             
             btn1.DataContext = btn1;
            EnterData enterData = new EnterData();
            enterData.Show();
            
             


            /* if(Companies[0].IsMainCompany == true)
             {
               foreach(Address address in Companies[0].CompanyAddress)
                 {
                     MessageBox.Show(address.FullAddress());
                 }
               foreach(Car car in Companies[0].Cars)
                 {
                     MessageBox.Show(car.GetCarDetails());
                 }
             }*/

           }

          private void Btn2_Click(object sender, RoutedEventArgs e)
            {

                btn2.DataContext = btn2;
                //btn2.Content = Companies[1].Name;                              
              /*  foreach (Address address in Companies[1].CompanyAddress)
                {
                    MessageBox.Show(address.FullAddress());
                }
                foreach (Car car in Companies[1].Cars)
                {
                    MessageBox.Show(car.GetCarDetails());
                }*/
            }
        /* private void Window_loaded(object sender, RoutedEventArgs e)
         {
            
            

            datagrid1.ItemsSource = Cars;
            
        }*/
    }
    }
   
    
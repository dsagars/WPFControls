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

namespace Test
{
    public partial class MainWindow : Window 
    {  
        public ObservableCollection<Company> Companies;
        public MainWindow()
        {
            InitializeComponent();
            Car car1 = new Car() { Brand = "Audi", Color = "aadasda", Doors = 4, Tires = 4, Model = "asdaddcccc", ManufactureDate = new DateTime(2016, 12, 2) };
            Car car2 = new Car() { Brand = "BMW", Color = "aaeweddasda", Doors = 4, Tires = 4, Model = "aeerweddcccc", ManufactureDate = new DateTime(2016, 12, 2) };
            Car car3 = new Car() { Brand = "Mercedes", Color = "aaeweddasda", Doors = 4, Tires = 4, Model = "aeerweddcccc", ManufactureDate = new DateTime(2016, 12, 2) };

            Address addressMainCompany = new Address() { Street = "Frankenstr.", HouseNumber = 12, PostalCode = 22111, City = "Hamburg" };
            Address addressSubCompany = new Address() { Street = "Hauptstr.", HouseNumber = 12, PostalCode = 22111, City = "Hamburg" };

            Companies = new ObservableCollection<Company>()
            {
                 new Company(){CompanyName = "Hsoft", IsMainCompany = true, Cars = new List<Car>{car1,car2}, CompanyAddress = new List<Address>{addressMainCompany,addressSubCompany}},
                 new Company(){CompanyName = "CFM", IsMainCompany = false , Cars = new List<Car>{car1,car3}, CompanyAddress = new List<Address>{addressSubCompany}},
                 new Company(){CompanyName = "CSM", IsMainCompany = false , Cars = new List<Car>{car2,car3}, CompanyAddress = new List<Address>{addressSubCompany}}
            };   
            datagrid1.DataContext = Companies;
            
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            EnterData enterData = new EnterData();
            enterData.Show();
        }

        
    }
}

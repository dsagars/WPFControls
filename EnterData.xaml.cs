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
using System.Windows.Shapes;
using System.Xml.Serialization;
using System.IO;
using System.Data;
using System.Collections.ObjectModel;



namespace Test
{

    public partial class EnterData : Window
    {
        XmlSerializer xs;
        List<Company> Companies;
        List<Address> Addresses;
        List<Car> CompanyCars;
        public EnterData()
        {

            InitializeComponent();
            xs = new XmlSerializer(typeof(List<Company>));
            Companies = new List<Company>();

            /*  Addresses = new List<Address>();
              Addresses.Add(new Test.Address { Street = "Frankenstr.", HouseNumber = 12, PostalCode = 20097, City = "Hamburg" });
              Addresses.Add(new Test.Address { Street = "Abcstr.", HouseNumber = 12, PostalCode = 20097, City = "Hamburg" });


              Car car1 = new Car() { Brand = "Audi", Model = "A8", Color = "Red", Doors = 2, Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) };
              Car car2 = new Car() { Brand = "BMW", Model = "coupe", Color = "Blue", Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) };
              Car car3 = new Car() { Brand = "Opel", Model = "Astra", Color = "Black", Doors = 2, Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) };
              Car car4 = new Car() { Brand = "Mercedes", Model = "Benz", Color = "Black", Doors = 4, Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) };
              CompanyCars = new List<Car>() { car1, car2, car3, car4 };*/
            
            dataGrid2.DataContext = Companies;



        }

        public void Save_Click(object sender, RoutedEventArgs e)
        {

            FileStream fs = new FileStream("C:\\CompanyDetails.xml", FileMode.Create, FileAccess.Write);
            Company company = new Company();
            company.CompanyName = textbox1.Text;
            company.IsMainCompany = bool.Parse(textbox2.Text);
          
            Companies.Add(company);
           
            xs.Serialize(fs, Companies);
            fs.Close();

        }


        private void Read_Click(object sender, RoutedEventArgs e)
        {

            FileStream fs = new FileStream("C:\\CompanyDetails.xml", FileMode.Open, FileAccess.Read);
            Companies = (List<Company>)xs.Deserialize(fs);
            dataGrid2.ItemsSource = Companies;
            fs.Close();
        }
 

       
    }
}

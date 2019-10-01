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

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
       

        public MainWindow()
        {
            
            Address addressMainCompany = new Address() { Street = "Frankenstr.", HouseNumber = 12, PostalCode = 22111, City = "Hamburg" };
            Address addressSubCompany = new Address() { Street = "Mönckebergstr.", HouseNumber = 1, PostalCode = 20095, City = "Hamburg" };
            List<Address> addresses = new List<Address> { addressMainCompany, addressSubCompany };

            Car car1 = new Car() { Brand = "Audi", Model = "A8", Color = "Red", Doors = 2, Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) };
            Car car2 = new Car() { Brand = "BMW", Model = "coupe", Color = "Blue", Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) };
            Car car3 = new Car() { Brand = "Opel", Model = "Astra", Color = "Black", Doors = 2, Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) };
            Car car4 = new Car() { Brand = "Mercedes", Model = "Benz", Color = "Black", Doors = 4, Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) };

            /* List<Company> companies = new List<Company>();
             companies.Add(new Company { Name = "Hanseaticsoft", Cars = new List<Car> { car1, car2, car3 }, IsMainCompany = true, CompanyAddress = new List<Address> { addressMainCompany } });
             companies.Add(new Company { Name = "Yadasdaa", Cars = new List<Car> { car4 }, IsMainCompany = false, CompanyAddress = new List<Address> { addressSubCompany } });

             companies.Add(new Company { Name = "Agttasade", Cars = new List<Car> { car2, car4 }, IsMainCompany = false, CompanyAddress = new List<Address> { addressSubCompany } });
             */
             public IList<Car> CompanyList = new IList<Car>();
            company1 = new Company();
           
            company2 = new Company();
            company3 = new Company { Name = "Ztreee", Cars = new List<Car> { car1, car3 }, IsMainCompany = false, CompanyAddress = new List<Address> { addressSubCompany } };
            
            InitializeComponent();
        }

        public class Company : ICorporation
        {

            public bool isMainCompany;


            public virtual string Name { get; set; }
            public virtual List<Car> Cars { get; set; }


            public virtual bool IsMainCompany { get; set; }
            public List<Address> CompanyAddress { get; set; }

            public virtual string CompanyDetail()
            {
                return $"CompanyName  : {Name}\n" +
                       $"IsMainCompany: {IsMainCompany}";
            }
            public List<Car> AddCars(List<Car> carsToAdd)
            {
                Cars.AddRange(carsToAdd);
                return Cars;

            }
        }


        /* var company2 = new Company();
         this.DataContext = companies;*/


        public void CompanyName_Click2(object sender, RoutedEventArgs e)
        {
            company2.Name = "SAB";
            Button button2 = new Button();
            if (button2.IsEnabled == true)
            {

                MessageBox.Show(company2.CompanyDetail());
                
            }

        }

        public void CompanyName_Click(object sender, RoutedEventArgs e)
        {
            company1.Name = "AUDI";
            Button button1 = new Button();
            if (button1.IsEnabled == true)
            {
                
                MessageBox.Show(company1.CompanyDetail());
                
            }
           



        }



    }
}

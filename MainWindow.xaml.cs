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
        protected List<Car> Cars { get; set; }
        protected List<Company> Companies { get; set; }
        public MainWindow()
        {
            Cars = new List<Car> {car1, car2} ;
            DataContext = Cars;
            Company company1 = new Company() { Name = "Hanseaticsoft", Cars = new List<Car>(), IsMainCompany = true, CompanyAddress = new List<Address>() };
            Companies = new List<Company> {company1};  

            DataContext = Companies;
            InitializeComponent();
        }
         

         Car car1 = new Car() { Brand = "Audi", Model = "A8", Color = "Red", Doors = 2, Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) };
         Car car2 = new Car() { Brand = "BMW", Model = "coupe", Color = "Blue", Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) };
         Car car3 = new Car() { Brand = "Opel", Model = "Astra", Color = "Black", Doors = 2, Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) };
         Car car4 = new Car() { Brand = "Mercedes", Model = "Benz", Color = "Black", Doors = 4, Tires = 4, ManufactureDate = new DateTime(2016, 08, 12) };

      
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            
            /* List<Car> cars = new List<Car>() {car1,car2,car3 };
            foreach (Car car in cars)
            {
                MessageBox.Show(car.GetCarDetails());
            }*/
            MessageBox.Show(Companies[0].CompanyDetail());
            if(Companies[0].IsMainCompany == true)
            {
                MessageBox.Show(Companies[0].Name);
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
              List<Car> cars = new List<Car>() { car2, car3 };
              foreach(Car car in cars)
            {
                MessageBox.Show(car.GetCarDetails());
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            List<Car> cars = new List<Car>() { car1, car3 };
            foreach (Car car in cars)
            {
                MessageBox.Show(car.GetCarDetails());
            }

        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            List<Car> cars = new List<Car>() { car1, car2 };
            foreach (Car car in cars)
            {
                MessageBox.Show(car.GetCarDetails());
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            List<Car> cars = new List<Car>() {car2, car3,car4 };
            foreach (Car car in cars)
            {
                MessageBox.Show(car.GetCarDetails());
            }
        }

       
    }
}

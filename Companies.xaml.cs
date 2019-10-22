using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Test
{
    /// <summary>
    /// Interaction logic for Companies.xaml
    /// </summary>
    public partial class Companies : Window
    {
        CompanyData company1;
        public ObservableCollection<CompanyData> mainWindowCompanyData;
        public CompanyAddress Address { get; set; }
        //public List<CompanyData> companyList = new List<CompanyData>();
        public CompanyAddress address;
        public Companies()
        {
            InitializeComponent();
            this.mainWindowCompanyData = new ObservableCollection<CompanyData>();
            

            List<CompanyCar> cars = new List<CompanyCar>();
            cars.Add(new CompanyCar("Audi A1"));
            cars.Add(new CompanyCar("BMW1"));
            cars.Add(new CompanyCar("VW"));

           
            company1 = new CompanyData("Hanseaticsoft GmbH", true, new CompanyAddress("Frankenstraße", 12), cars);
            mainWindowCompanyData.Add(company1);

            //CompanyListView.ItemsSource = mainWindowCompanyData;

            this.DataContext = mainWindowCompanyData;
        }
     
        private void Add_Company(object sender, RoutedEventArgs e)
        {

            var add = new AddWindow(mainWindowCompanyData);
            add.Show();
        }

        public void Save(CompanyData company)
        {
            company1 = company;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            mainWindowCompanyData.Remove(CompanyListView.SelectedItem as CompanyData);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {         
            foreach(CompanyData data in mainWindowCompanyData)
            {
                if(CompanyListView.SelectedItem == data)
                {
                    var edit = new EditCompany(data);

                    edit.Show();
                    
                }
                
            }
             

        }

       
    }
}

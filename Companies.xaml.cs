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
        //public List<CompanyData> companyList = new List<CompanyData>();

        public Companies()
        {
            InitializeComponent();
            this.mainWindowCompanyData = new ObservableCollection<CompanyData>();
            this.DataContext = mainWindowCompanyData;

            List<CompanyCar> cars = new List<CompanyCar>();
            cars.Add(new CompanyCar("Audi A1"));
            cars.Add(new CompanyCar("BMW1"));
            cars.Add(new CompanyCar("VW"));

            company1 = new CompanyData("Hanseaticsoft GmbH", true, new CompanyAddress("Frankenstraße", 12), cars);
            mainWindowCompanyData.Add(company1);
            //companyList.Add(company1);

            //CompanyListView.Items.Add(companyList);
           // CompanyListView.ItemsSource = companyList;
            CompanyListView.ItemsSource = mainWindowCompanyData;
        }
     
        private void Add_Company(object sender, RoutedEventArgs e)
        {
            var add = new AddWindow(mainWindowCompanyData);
            add.Show();
        }

        public void save(CompanyData company)
        {
            company1 = company;
        }
    }
}

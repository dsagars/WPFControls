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

namespace Test
{
    /// <summary>
    /// Interaction logic for Companies.xaml
    /// </summary>
    public partial class Companies : Window
    {
        CompanyData company1;

        public Companies()
        {
            InitializeComponent();

            List<CompanyCar> cars = new List<CompanyCar>();
            cars.Add(new CompanyCar("Audi A1"));
            cars.Add(new CompanyCar("BMW1"));
            cars.Add(new CompanyCar("VW"));

            company1 = new CompanyData("Hanseaticsoft GmbH", true, new CompanyAddress("Frankenstraße", 12), cars);
             List<CompanyData> companyList = new List<CompanyData>();
            companyList.Add(company1);
            listViewCompany.Items.Add(companyList);

            EditCompany entry = new EditCompany(company1,this);
            entry.ValueChanged += new EditCompany.ValueChangedHandler(entryValueChanged);
        }

            private void entryValueChanged(CompanyData data)
            {
            
            }

        private void Edit_Company(object sender, RoutedEventArgs e)
        {
            EditCompany edit = new EditCompany(company1, this);
            edit.Show();
        }

        public void save(CompanyData company)
        {
            company1 = company;
        }

     
      
    }
}

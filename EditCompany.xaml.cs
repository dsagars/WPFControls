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
using System.Collections.ObjectModel;
namespace Test
{
    /// <summary>
    /// Interaction logic for EditCompany.xaml
    /// </summary>
    public partial class EditCompany : Window
    {
        //Companies window;
        CompanyData companyToBeEdited;
        Companies companyBase;
        private ObservableCollection<CompanyData> editWindowCompanyData;
        public EditCompany(CompanyData company)
        {
            InitializeComponent();
            companyToBeEdited = company;
            this.DataContext = companyToBeEdited;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            CompanyData data = new CompanyData(1,companyNameTxtBox.Text, false,null, null);
        }

    }
}

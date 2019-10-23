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
    /// Interaction logic for AddorEdit.xaml
    /// </summary>
    public partial class AddorEdit : Window
    {
        private ObservableCollection<CompanyData> newCompanyCollection;
        private CompanyData newCompany;
        private ListView addOrEditListView;
        public AddorEdit(ObservableCollection<CompanyData> existingCompanies , CompanyData company, ListView list)
        {
            InitializeComponent();
            this.newCompanyCollection = existingCompanies;
            this.newCompany = company;
            this.addOrEditListView = list;
            this.DataContext = newCompanyCollection;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            CompanyData data = new CompanyData(int.Parse(iDAddOrEditTxtBox.Text), companyNameAddOrEditTxtBox.Text, true, null, null);
            if (data.Id == (addOrEditListView.SelectedIndex + 1))
            {
                data.CompanyName = companyNameAddOrEditTxtBox.Text;
                data.Id = int.Parse(iDAddOrEditTxtBox.Text);
                data.Address = null;
                data.Cars = null;
            }
            
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            
            CompanyData data = new CompanyData(int.Parse(iDAddOrEditTxtBox.Text), companyNameAddOrEditTxtBox.Text, true, null, null);
            newCompanyCollection.Add(data);
            
            
        }
    }
}

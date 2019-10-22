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

    public partial class AddWindow : Window
    {
        private ObservableCollection<CompanyData> companyData;
        private ObservableCollection<Companies> companies;
        CompanyData currentItem;

        
        public AddWindow()
        {
            InitializeComponent();
            
        }
        public AddWindow(ObservableCollection<CompanyData> _companyData)
        {
            this.companyData = _companyData;
            InitializeComponent();
            this.DataContext = companyData;
             
            
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            
            CompanyAddress newAdd = new CompanyAddress(txtStreet.Text, int.Parse(txtnumber.Text));
            
            CompanyData data = new CompanyData(saveNowTextBox.Text,false, newAdd , null);
            
            if(isMainCompanyCheckBox.IsChecked == true)
            {
                data.isMainCompany = true;
            }
            else
            {
                data.isMainCompany = false;
            }
            companyData.Add(data);
            

            
            
            
        }
    }
}

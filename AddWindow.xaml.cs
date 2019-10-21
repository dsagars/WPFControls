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

        private CompanyData data { get; set; }
        public AddWindow()
        {
            InitializeComponent();

        }
        public AddWindow(ObservableCollection<CompanyData> _companyData)
        {
            this.companyData = _companyData;
            InitializeComponent();
            this.DataContext = this.companyData;
             
            
        }
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
           CompanyData data = new CompanyData(saveNowTextBox.Text, true, null, null);
            //saveNow.DataContext = data;
            companyData.Add(data);

            
            
            
        }
    }
}

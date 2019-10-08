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
        private ObservableCollection<Company> Companies = new ObservableCollection<Company>();
        
      
        public EnterData()
        {
            
            InitializeComponent();
            xs = new XmlSerializer(typeof(ObservableCollection<Company>));
            Companies = new ObservableCollection<Company>();
            DataContext = this;
            dataGrid2.DataContext = Companies;
            


        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            
            FileStream fs = new FileStream("C:\\CompanyDetails.xml", FileMode.Create, FileAccess.Write);
            Company company = new Company();
            textbox1.Text = company.CompanyName;
            textbox2.Text = Convert.ToString(company.IsMainCompany);
            textbox3.Text = Convert.ToString(company.CompanyAddress);
            textbox4.Text = Convert.ToString(company.Cars);
            Companies.Add(company);    
            xs.Serialize(fs, Companies);
            fs.Close();

        }

        private void Read_Click(object sender, RoutedEventArgs e)
        {
           
            FileStream fs = new FileStream("C:\\CompanyDetails.xml", FileMode.Open, FileAccess.Read);
            Companies = (ObservableCollection<Company>)xs.Deserialize(fs);
            dataGrid2.ItemsSource = Companies;
            fs.Close();
        }
    }
}

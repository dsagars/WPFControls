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

namespace Test
{
    
    public partial class EnterData : Window
    {
        XmlSerializer xs;
        List<Company> Companies;
        public EnterData()
        {
            InitializeComponent();
            Companies = new List<Company>();
            
            xs = new XmlSerializer(typeof(List<Company>));
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("F:\\CompanyDetail.xml", FileMode.Create, FileAccess.Write);
            
            Company company = new Company();

            textbox1.Text = company.Name;
            textbox2.Text = Convert.ToString(company.IsMainCompany);
            Companies.Add(company);
            xs.Serialize(fs, Companies);
            fs.Close();

        }

        private void Read_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("F:\\CompanyDetail.xml", FileMode.Open, FileAccess.Read);
            Companies = (List<Company>)xs.Deserialize(fs);
            datagridView1.ItemsSource = Companies;
            fs.Close();
        }
    }
}

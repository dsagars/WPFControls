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
using System.Collections.Specialized;


namespace Test
{

    public partial class EnterData : Window, INotifyCollectionChanged
    {
        XmlSerializer xs;
        ObservableCollection<Company> CompanyCollection;
        ObservableCollection<Address> Addresses;
        ObservableCollection<Car> CompanyCars;
        
        public EnterData()
        {

            InitializeComponent();
            xs = new XmlSerializer(typeof(ObservableCollection<Company>));
            CompanyCollection = new ObservableCollection<Company>();
           
            dataGrid2.DataContext = CompanyCollection;
            
            


        }
        
        public void Save_Click(object sender, RoutedEventArgs e)
        {

            FileStream fs = new FileStream("C:\\CompanyDetails.xml", FileMode.Create, FileAccess.Write);
            Company company = new Company();
            company.CompanyName = textbox1.Text;
            company.IsMainCompany = bool.Parse(textbox2.Text);
            CompanyCollection.Add(company);

            xs.Serialize(fs, CompanyCollection);
            fs.Close();

        }
       
        private void Read_Click(object sender, RoutedEventArgs e)
        {

            FileStream fs = new FileStream("C:\\CompanyDetails.xml", FileMode.Open, FileAccess.Read);
            CompanyCollection = (ObservableCollection<Company>)xs.Deserialize(fs);
            dataGrid2.ItemsSource = CompanyCollection;
            fs.Close();
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;
       
        

    }
}

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
    /// Interaction logic for EditCompany.xaml
    /// </summary>
    public partial class EditCompany : Window
    {
        Companies window;
        public delegate Companies ValueChangedHandler(CompanyData data);
        public event ValueChangedHandler ValueChanged; 

        public EditCompany(CompanyData company, Companies window)
        {
            InitializeComponent();

            this.window = window;
            txtCompanyName.Text = company.CompanyName;
        }

       

        private void Save_Click(object sender, RoutedEventArgs e)
        {
         if(ValueChanged != null)
            {
                ValueChanged(window); ;
            }
        }
        private void save()
        {
            window.save(new CompanyData("", true, null, null));
        }
    }
}
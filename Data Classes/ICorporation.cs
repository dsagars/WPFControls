using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;
using System.IO;
namespace Test
{
    public interface ICorporation 
    {
        string CompanyName { get; set; }

        ObservableCollection<Car> Cars { get; set; }

        ObservableCollection<Address> CompanyAddress { get; set; }


        bool IsMainCompany { get; set; }

        string CompanyDetail();




    }
}


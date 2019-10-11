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

        List<Car> Cars { get; set; }

        List<Address> CompanyAddress { get; set; }


        bool IsMainCompany { get; set; }

        string CompanyDetail();




    }
}


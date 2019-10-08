using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
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


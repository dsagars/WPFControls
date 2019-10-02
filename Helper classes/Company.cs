using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Test
{
    public class Company : ICorporation
    {

        public bool isMainCompany;
        public virtual string Name { get; set; }      
        public virtual List<Car> Cars { get; set; }
        public virtual bool IsMainCompany { get; set; }
        public List<Address> CompanyAddress { get; set; }

        public Company()
        {
            Cars = this.Cars; 
        }

        public virtual string CompanyDetail()
        {
            return $"CompanyName  : {Name}\n" +
                   $"IsMainCompany: {IsMainCompany}";
        }
        
        
       
    }
}

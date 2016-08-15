using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactory.Product
{
    class ToyotaCar : ICar
    {
       
        public ToyotaCar()
        {

        }
       
        public string GetCompanyName
        {
            get
            {
               return "Toyota";
            }
        }

        public string GetFounderName
        {
            get
            {
                return "Kiichiro Toyoda";
            }
        }

        public string Headquarter
        {
            get
            {
                return "Toyota, Aichi, Japan";
            }
        }

    
    }
}

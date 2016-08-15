using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Product
{
    class FordCar : ICar
    {
        public string GetCompanyName
        {
            get
            {
                return "Ford Motor Company";
            }
        }

        public string GetFounderName
        {
            get
            {
                return "Henry Ford";
            }
        }

        public string Headquarter
        {
            get
            {
                return "Dearborn, Michigan, U.S.";
            }
        }
    }
}

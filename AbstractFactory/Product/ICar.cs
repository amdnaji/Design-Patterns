using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactory.Product
{
    interface ICar
    {
        
        string GetCompanyName { get; }
        string GetFounderName { get; }
        string Headquarter { get;  }
        //int ManufacturingYear { set; get; }
    }
}

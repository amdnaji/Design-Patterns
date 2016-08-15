using AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    class FordFactory : ICarFactory
    {
        public ICar CreateCar
        {
            get
            {
                return new FordCar();
            }
        }
    }
}

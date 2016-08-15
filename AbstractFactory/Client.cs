using AbstractFactory.Factory;
using AbstractFactory.Product;

namespace AbstractFactory
{
    class Client
    {
        ICar car;
        ICarFactory carFactory;

        public void CreateFactory(ICarFactory carFactory)
        {
            this.carFactory = carFactory;

            car = carFactory.CreateCar;
        }
        public string CompanyName
        {
            get
            {
                return car.GetCompanyName;
            }
        }
        public string FounderName
        {
            get
            {
                return car.GetFounderName;
            }
        }
        public string Headquarter
        {
            get
            {
                return car.Headquarter;
            }
        }

    }
}

using AbstractFactory.Factory;
using AbstractFactory.Product;

namespace AbstractFactory
{
    /// <summary>
    /// The main goal of the client is to contact with abstract facotry
    /// </summary>
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

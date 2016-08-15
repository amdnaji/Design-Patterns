using AbstractFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client class will communicate with Factories as following
            Client client = new Client();
            Console.WriteLine("====== First Factory ======\n");
            client.CreateFactory(new ToyotaFactory());
            Console.WriteLine(client.CompanyName);
            Console.WriteLine(client.FounderName);
            Console.WriteLine(client.Headquarter);
            Console.WriteLine("\n====== Second Factory ======\n");
            client.CreateFactory(new FordFactory());
            Console.WriteLine(client.CompanyName);
            Console.WriteLine(client.FounderName);
            Console.WriteLine(client.Headquarter);

            Console.ReadKey();
        }
    }
}

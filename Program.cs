using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.PrName = "Шестренка";
            product.PrCipher = "3434fff3";
            product.PrNumber = 10000;

            Product prod1 = new Product("Шируп", "32ddf211", 100000);

            Console.WriteLine($"{product.PrName} {product.PrCipher} {product.PrNumber}");
            Console.ReadKey();
        }
    }
}

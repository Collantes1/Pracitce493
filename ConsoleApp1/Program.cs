using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation Calculator = new Calculation();

            int productType = 3;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = 45;

            int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, length);
            Console.WriteLine(materialCount);

            Console.ReadKey();

        }
    }
}

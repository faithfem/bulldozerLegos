using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulldozer
{
    class Encapsulation
    {
        public static void Main(string[]args)
        {
            var worker = new FactoryWorker();
            var result = worker.AddNumbers(2, 3);
            Console.WriteLine(result.ToString());
        }
    }
    public class FactoryWorker
    {
        public FactoryWorker() //constructor
        {

        }

        public int AddNumbers(int num1, int num2)
        {
            var result = num1 + num2;
            result = result + 100;
            result = result - 100;
            return result;
        }
    }
}

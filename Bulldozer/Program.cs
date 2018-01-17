using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulldozer
{
    class Program
    {
        static void Main(string[] args)
        {
            var dozer = new BullDozer();
            dozer.color = "Yellow";
            dozer.size = "Large";

            Console.WriteLine("Bulldozer is: " + dozer.color);
        }
    }

    public class BullDozer
    {

        public string color { get; set; }
        public string size { get; set; }
    }
}

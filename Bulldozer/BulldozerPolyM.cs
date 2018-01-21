using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

//POLYMORPHISM EXAMPLE
//2 METHODS EACH WITH A DIFFERENT INPUT TYPE THAT ALLOW YOU
//TO DO THE SAME THING

namespace Bulldozer
{
    class BulldozerPolyM
    {
        public static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            worker.Count(4);
            worker.Count(5);
            worker.Count(4.5f);
        }
    }

    //CREATE CLASSES BELOW THE ABOVE

    public class FactoryWorker
    {
        //create a constructor remember same name as class
        
        public FactoryWorker()
        {

        }

        public void Count(int number)
        {
            if (Total == 0)
                Total = 0;

            Total = Total + Convert.ToSingle (number);
            Console.WriteLine(Total.ToString());
        }

        public void Count(float number)//same method name is not good, but can be used if using a different type of variable. Here a variable, above an int
        {
            Total = Total + number;
            Console.WriteLine(Total.ToString());
        }
        public float Total { get; set; }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            ChocolateBoilerF boiler = ChocolateBoilerF.getInstance();
            boiler.fill();
            boiler.fill();
            boiler.drain();
            boiler.boil();
            boiler.drain();
            Console.ReadKey();
        }
    }
}

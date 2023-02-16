using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        public ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }
        public void fill()
        {
            if(isEmpty())
            {
                empty = false;
                boiled = false;
            }        
        }

        public void drain()
        {
            if(!isEmpty() && isBoiled())
            {
                empty = true;
                Console.WriteLine("Contenedor drenado");
            }
        }

        public void boil()
        {
            if(!isEmpty() && !isBoiled())
            {
                boiled = true;
            }
        }

        public bool isEmpty()
        {
            return empty;
        }
        public bool isBoiled()
        {
            return boiled;
        }
    }
}

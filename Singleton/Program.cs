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
            //singleton unicainstancia = new singleton(); Esto no se puede hacer
            //porque el constructor es privado
            //Se crea unicamente la instancia singleton sin inicializar
            singleton unicainstancia = singleton.getInstance();
            //singleton instancia2 = unicainstancia;
            ChocolateBoilerF boiler = ChocolateBoilerF.getInstance();
            //debemos de llamar al metodo de get instance para poder inicializar el objeto.
            /*Singleton instancia = Singleton.getInstance();
            Singleton nuevo = instancia;*/
            Console.ReadKey();
        }
    }
}

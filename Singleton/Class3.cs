using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	class ChocolateBoilerF
	{
		private bool empty;
		private bool boiled;
		private static ChocolateBoilerF uniqueInstance;
		private static readonly object InstanceLoker = new Object();

		private ChocolateBoilerF()
		{
			empty = true;
			boiled = false;
		}

		public static ChocolateBoilerF getInstance()
		{
			if (uniqueInstance == null)
			{
				lock (InstanceLoker)
				{
					if (uniqueInstance == null)
						Console.WriteLine("Creacion de unica instancia de Chocolate Boiler");
						uniqueInstance = new ChocolateBoilerF();
				}
			}
			Console.WriteLine("Regresando la instancia de Chocolate Boiler");
			return uniqueInstance;
		}

		public void fill()
		{
			if (isEmpty())
			{
				empty = false;
				boiled = false;
				Console.WriteLine("Contenedor lleno");
				//se llena el boiler con mezcla de leche con chocolate
			}
		}

		public void drain()
		{
			if (!isEmpty() && isBoiled())
			{
				// se vacia  la leche y chocolate hervido
				empty = true;
				Console.WriteLine("Contenedor drenado");
			}
		}

		public void boil()
		{
			if (!isEmpty() && !isBoiled())
			{
				// bring the contents to a boil
				boiled = true;
				Console.WriteLine("La mezcla está hirviendo");
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


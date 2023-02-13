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

		private ChocolateBoilerF()
		{
			empty = true;
			boiled = false;
		}

		public static ChocolateBoilerF getInstance()
		{
			if (uniqueInstance == null)
			{
				Console.WriteLine("Creating unique instance of Chocolate Boiler");
				uniqueInstance = new ChocolateBoilerF();
			}
			Console.WriteLine("Returning instance of Chocolate Boiler");
			return uniqueInstance;
		}

		public void fill()
		{
			if (isEmpty())
			{
				empty = false;
				boiled = false;
				// fill the boiler with a milk/chocolate mixture
			}
		}

		public void drain()
		{
			if (!isEmpty() && isBoiled())
			{
				// drain the boiled milk and chocolate
				empty = true;
			}
		}

		public void boil()
		{
			if (!isEmpty() && !isBoiled())
			{
				// bring the contents to a boil
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


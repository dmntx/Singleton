using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Singleton
{
    /*public class singleton
    {
        private static singleton uniqueInstance;
        private singleton() { }
        public static singleton getInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new singleton();
            }

            return uniqueInstance;
        }
    }*/

    public sealed class Singleton
    {
        private static volatile Singleton uniqueInstance;
        private static readonly object InstanceLoker = new Object();

        private Singleton() { }

        public static Singleton getInstance()
        {
                if (uniqueInstance == null)
                {
                    lock (InstanceLoker)
                    {
                        if (uniqueInstance == null)
                            uniqueInstance = new Singleton();
                    }
                }
                return uniqueInstance;
        }
    }
}

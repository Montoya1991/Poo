using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Car
    {
        public int id;
        public string license;
        public string driver;
        public int passanger;

        public void ImprimirCar()
        {
            Console.WriteLine("Licence: " + license + " Driver: " + driver);
        }
    }
}

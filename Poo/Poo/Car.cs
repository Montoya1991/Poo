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
        public Account driver;
        private int passanger;


        public Car(string licence, Account driver)
        {
            this.license = licence;
            this.driver = driver;

        }
        public void ImprimirCar()
        {
            if (getPassanger == 4)
            {
                passanger = getPassanger;
                Console.WriteLine("Licence: " + license + " Name Driver: " + driver.name + " Passanger " + passanger);
            }
            else
            {
                Console.WriteLine("Necesitas asigar cuatro pasajeros");
            }

        }
        public int getPassanger { get; set; }



    }
}

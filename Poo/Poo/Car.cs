using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Car
    {
        private int id;
        private string license;
        private Account driver;
        private int passanger;

        public int getid { get; set; }

        public int getlicense { get; set; }
        public int getdriver { get; set; }

        public int getPassanger()
        {
            return passanger;
        }

        public void setPassanger(int passanger)
        {
            if (passanger == 4)
            {
                this.passanger = passanger;
            }
            else
            {
                Console.WriteLine("Necesitas asigar cuatro pasajeros");
            }
        }
        public Car(string licence, Account driver)
        {
            this.license = licence;
            this.driver = driver;

        }
        public void ImprimirCar()
        {
            if (passanger != null)
            {
                Console.WriteLine("Licence: " + license + " Name Driver: " + driver.name + " Passanger " + passanger);
            }
        }



    }
}

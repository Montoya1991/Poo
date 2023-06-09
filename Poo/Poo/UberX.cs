using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class UberX : Car
    {
        public string brand;
        public string Model;
        public UberX(string licence, Account driver, string brand, string model) : base(licence, driver)
        {
            this.brand = brand;
            this.Model = model;
        }
    }
}
// Esta es una clase hija que hereda de la clase padre Car
// al colocar dos puntos mas nombre de la clase padre heredara de la clase padre
// la balabra base hace referencia a la clase padre si se coloca base + . podremos ver las propiedades y metodos de la clase padre

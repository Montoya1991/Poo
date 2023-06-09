using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class UberPool : Car
    {
        public string brand;
        public string Model;
        public UberPool(string licence, Account driver, string brand, string model) : base(licence, driver)
        {
            
        }
    }
}

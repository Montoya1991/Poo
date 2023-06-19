using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class UberVan : Car
    {
        Dictionary<string, List<Tuple<string, int>>> typeAccepted;
        List<string> seatMaterial = new List<string>();
        public UberVan(string licence, Account driver, Dictionary<string, List<Tuple<string, int>>> typeAccepted, List<string> seatMaterial) : base(licence, driver)
        {
            this.typeAccepted = typeAccepted;
            this.seatMaterial = seatMaterial;
        }
        public UberVan(string licence, Account driver) : base(licence, driver)
        {
            this.typeAccepted = typeAccepted;
            this.seatMaterial = seatMaterial;
        }
    }
}

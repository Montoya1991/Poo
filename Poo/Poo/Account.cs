using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Account
    {
        int id;
        public string name;
        public string document;
        string email;
        string password;

        public Account(string name, string document)
        {
            this.name = name;
            this.document = document;
        }
    }
}

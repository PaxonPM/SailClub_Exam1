using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class Admin : Person
    {
        public bool IsAdmin { get; set; } = true;

        public Admin(int id, string name, string address, string mail, string phone)
            : base(id, name, address, mail, phone)
        { }
    }
}
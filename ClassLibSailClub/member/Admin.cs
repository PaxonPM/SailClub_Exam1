using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class Admin : Person
    {
        public DateTime AdminSince { get; private set; }

        public Admin(int id, string name, string address, string mail, string phone)
            : base(id, name, address, mail, phone)
        {
            IsAdmin = true;
            AdminSince = DateTime.Now;
            Role = "Administrator";
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Admin Signupdate: {AdminSince}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
        public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }

        public Person(int id, string name, string address, string mail, string phone)
        {
            Id = id;
            Name = name;
            Address = address;
            Mail = mail;
            Phone = phone;
        }

        public void UpdatePhone(string newPhone) => Phone = newPhone;
        public void UpdateAdress(string newAddress) => Address = newAddress;
        public void UpdateMail(string newMail) => Mail = newMail;
    }
}

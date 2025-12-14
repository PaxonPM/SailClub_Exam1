using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibSailClub
{
        public abstract class Person : IValidate
    {
        public int Id { get; }
        public string Name { get; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public bool IsAdmin { get; protected set; } = false;

        public Person(int id, string name, string address, string mail, string phone)
        {
            Id = id;
            Name = name;
            Address = address;
            Mail = mail;
            Phone = phone;
        }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentException("Name is required.");
            if (string.IsNullOrWhiteSpace(Address))
                throw new ArgumentException("Address is required.");
            if (string.IsNullOrWhiteSpace(Mail))
                throw new ArgumentException("Mail is required.");
            if (string.IsNullOrWhiteSpace(Phone))
                throw new ArgumentException("Phone is required.");

        }

        public bool TryValidate()
        {
            if (Phone.Length == 8) return false;

            return true;
        }
    }
}

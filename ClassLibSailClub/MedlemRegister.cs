using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class MedlemRegister
    {
        private readonly Dictionary<int, Medlem> medlemmer = new();

        public void CreateMedlem(int id, string name, string address, string mail, string phone, bool areYouAdmin = false)
        {
            if (medlemmer.ContainsKey(id))
                throw new ArgumentException($"Et medlem med ID {id} findes allerede!");

            medlemmer[id] = new Medlem(id, name, address, mail, phone, areYouAdmin);
        }

        public Medlem GetMedlem(int id)
        {
            if (!medlemmer.TryGetValue(id, out var medlem))
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");

            return medlem;
        }

        public void UpdateMedlem(int id, string name, string address, string mail, string phone, bool areYouAdmin = false)
        {
            if (!medlemmer.TryGetValue(id, out var medlem))
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");

            medlem.Name = name;
            medlem.Address = address;
            medlem.Mail = mail;
            medlem.Phone = phone;
            medlem.AreYouAdmin = areYouAdmin;
        }

        public void DeleteMedlem(int id)
        {
            if (!medlemmer.Remove(id))
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");
        }

        public void PrintMedlemmer()
        {
            if (medlemmer.Count == 0)
            {
                throw new ArgumentNullException("Ingen medlemmer i systemet.");
            }

            foreach (var medlem in medlemmer.Values)
            {
                Console.WriteLine(
                    $"ID: {medlem.Id}, Navn: {medlem.Name}, Adresse: {medlem.Address}, Mail: {medlem.Mail}, Telefon: {medlem.Phone}, Admin: {medlem.AreYouAdmin}"
                );
            }
        }
    }
}
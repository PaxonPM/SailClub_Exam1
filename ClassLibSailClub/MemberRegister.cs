using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class MemberRegister
    {
        private readonly Dictionary<int, Member> members = new();

        public void CreateMember(int id, string name, string address, string mail, string phone, bool areYouAdmin = false)
        {
            if (members.ContainsKey(id))
                throw new ArgumentException($"Et medlem med ID {id} findes allerede!");

            members[id] = new Member(id, name, address, mail, phone, areYouAdmin);
        }

        public Member GetMember(int id)
        {
            if (!members.TryGetValue(id, out var medlem))
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");

            return medlem;
        }

        public void UpdateMember(int id, string name, string address, string mail, string phone, bool isAdmin = false)
        {
            if (!members.TryGetValue(id, out var member))
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");

            member.Name = name;
            member.Address = address;
            member.Mail = mail;
            member.Phone = phone;
            member.IsAdmin = isAdmin;
        }

        public void DeleteMember(int id)
        {
            if (!members.Remove(id))
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");
        }

        public void PrintMembers()
        {
            if (members.Count == 0)
            {
                throw new ArgumentNullException("Ingen medlemmer i systemet.");
            }

            foreach (Member member in members.Values)
            {
                Console.WriteLine(
                    $"ID: {member.Id}, Navn: {member.Name}, Adresse: {member.Address}, Mail: {member.Mail}, Telefon: {member.Phone}, Admin: {member.IsAdmin}"
                );
            }
        }
    }
}
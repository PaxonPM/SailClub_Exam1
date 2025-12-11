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

        public void CreateMember(Member tempMember)
        {
            if (members.ContainsKey(tempMember.Id))
                throw new ArgumentException($"Et medlem med ID {tempMember.Id} findes allerede!");

            members[tempMember.Id] = tempMember;
        }

        public Member GetMember(int id)
        {
            if (!members.TryGetValue(id, out var medlem))
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");

            return medlem;
        }

        public void UpdateMember(int id, string name, string address, string mail, string phone, DateTime signUpDate)
        {
            if (!members.TryGetValue(id, out var member))
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");

            member.Name = name;
            member.Address = address;
            member.Mail = mail;
            member.Phone = phone;

        }

        public void DeleteMember(int id)
        {
            if (!members.Remove(id))
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");
        }

        public void PrintMembers()
        {
            if (members.Count == 0)
                throw new ArgumentNullException("Ingen medlemmer i systemet.");

            foreach (Member member in members.Values)
            {
                Console.WriteLine(
                    $"ID: {member.Id}, Navn: {member.Name}, Adresse: {member.Address}, Mail: {member.Mail}, " +
                    $"Telefon: {member.Phone}, Medlem siden: {member.SignUpDate}"
                );
            }
        }
    }
}
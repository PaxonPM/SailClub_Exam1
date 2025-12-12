using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class MemberRegister
    {
        public Dictionary<int, Member> Members { get; set; } = new();

        public void AddMember(Member tempMember)
        {
            if (Members.ContainsKey(tempMember.Id))
                throw new ArgumentException($"Et medlem med ID {tempMember.Id} findes allerede!");

            Members[tempMember.Id] = tempMember;
        }

        public Member GetMember(int id)
        {
            if (!Members.TryGetValue(id, out var medlem))
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");

            return medlem;
        }

        public void UpdateMember(int id, string name, string address, string mail, string phone, DateTime signUpDate)
        {
            if (!Members.TryGetValue(id, out var member))
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");

            member.Name = name;
            member.Address = address;
            member.Mail = mail;
            member.Phone = phone;

        }

        public void DeleteMember(int id)
        {
            if (!Members.Remove(id))
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");
        }

        public Dictionary<int, Member> PrintMembers()
        {
            if (Members.Count == 0)
                throw new ArgumentNullException("Ingen medlemmer i systemet.");

            return Members;
        }
    }
}
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

        public void CreateMember(Member tempMember)
        {
            if (Members.ContainsKey(tempMember.Id))
                throw new ArgumentException($"Et medlem med ID {tempMember.Id} findes allerede!");

            Members[tempMember.Id] = tempMember;
        }

        public Member ReadMember(int id)
        {

            if (!Members.TryGetValue(id, out var medlem))
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");
            return medlem;
        }

        public Member UpdateMember(int id, string address, string mail, string phone)
        {
            if (!Members.TryGetValue(id, out var member))
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");

            member.Address = address;
            member.Mail = mail;
            member.Phone = phone;

            return member;

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
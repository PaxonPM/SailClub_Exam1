using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class MemberRegister : IMemberRegister
    {
        public Dictionary<int, Person> Members { get; set; } = new();

        public Person CreateMember(Person tempMember)
        {
            if (Members.ContainsKey(tempMember.Id))
                throw new ArgumentException($"Et medlem med ID {tempMember.Id} findes allerede!");

            Members[tempMember.Id] = tempMember;
            return tempMember;
        }

        public Person ReadMember(int id)
        {

            if (!Members.TryGetValue(id, out var medlem))
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");
            return medlem;
        }

        public Person UpdateMember(int id, string address, string mail, string phone)
        {
            if (!Members.TryGetValue(id, out var member))
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");

            member.Address = address;
            member.Mail = mail;
            member.Phone = phone;

            return member;

        }

        public Person DeleteMember(int id)
        {
            if (!Members.TryGetValue(id, out var member))
            {
                throw new KeyNotFoundException($"Medlem med ID {id} blev ikke fundet.");
            }

            Members.Remove(id);
            return member;
        }

        public Dictionary<int, Person> PrintMembers()
        {
            if (Members.Count == 0)
                throw new ArgumentNullException("Ingen medlemmer i systemet.");

            return Members;
        }
    }
}
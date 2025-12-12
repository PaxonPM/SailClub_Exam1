using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public interface IMemberRegister
    {
        Dictionary<int, Member> Members { get; set; }
        void CreateMember(int id, string name, string address, string mail, string phone, bool areYouAdmin = false);
        Member GetMember(int id);
        void UpdateMember(int id, string name, string address, string mail, string phone, bool isAdmin = false);
        void DeleteMember(int id);
        void PrintMembers();
    }
}

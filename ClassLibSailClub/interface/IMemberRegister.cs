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
        Member CreateMember(Member tempMember);
        Member ReadMember(int id);
        Member UpdateMember(int id, string address, string mail, string phone);
        Member DeleteMember(int id);
        Dictionary<int, Member> PrintMembers();
    }
}

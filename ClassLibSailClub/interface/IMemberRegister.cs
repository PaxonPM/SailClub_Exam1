using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public interface IMemberRegister
    {
        Dictionary<int, Person> Members { get; set; }
        Person CreateMember(Person tempMember);
        Person ReadMember(int id);
        Person UpdateMember(int id, string address, string mail, string phone);
        Person DeleteMember(int id);
        Dictionary<int, Person> PrintMembers();
    }
}

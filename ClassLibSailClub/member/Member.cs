using System.Data;
using System.Security.Cryptography;

namespace ClassLibSailClub
{
    public class Member : Person
    {
        public DateTime MemberSince { get; private set; }

        public Member(int id, string name, string address, string mail, string phone)
            : base(id, name, address, mail, phone)
        {
            MemberSince = DateTime.Now;
            IsAdmin = false;
            Role = "Member";

        }
        public override string ToString()
        {
            return $"{base.ToString()}, Member SignUp: {MemberSince}";
        }


    }

}
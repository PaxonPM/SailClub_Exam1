namespace ClassLibSailClub
{
    public class Member : Person
    {
        public DateTime SignUpDate { get; private set; }

        public Member(int id, string name, string address, string mail, string phone, DateTime signUpDate)
            : base(id, name, address, mail, phone)
        {
            SignUpDate = DateTime.Now;
        }
    }
}
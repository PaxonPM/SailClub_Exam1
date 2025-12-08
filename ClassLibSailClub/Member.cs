namespace ClassLibSailClub
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }


        public bool AreYouAdmin { get; set; } = false;

        //Constructor
        public Member(int id, string name, string address, string mail, string phone, bool areYouAdmin = false)
        {
            Id = id;
            Name = name;
            Address = address;
            Mail = mail;
            Phone = phone;
            AreYouAdmin = areYouAdmin;
        }

        //Methods
        public void UpdatePhone(string newPhone)
        {
            Phone = newPhone;
        }

        public void UpdateAdress(string newAddress)
        {
            Address = newAddress;
        }

        public void UpdateMail(string newMail)
        {
            Mail = newMail;
        }
    }
}
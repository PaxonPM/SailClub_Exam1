using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public static class Initialize
    {
        public static void Start()
        {
            var BoatReg = new BoatReg();
            Boat boat1 = new MotorBoat();
            BoatReg.AddBoat(boat1);
            BoatReg.AddBoat("Speedbåd", "Sunseeker", 1992, "Slice of Life", 001, "Volvo 500 hk", 27.0);
            BoatReg.AddBoat("Sejlbåd", "Maxi", 1978, "Titanic", 002, "Volvo Penta MD7A", 28.0);
            BoatReg.AddBoat("RIB", "Njord Frigg 300", 2023, "Peter", 003, "20 hk", 10.0);
            BoatReg.AddBoat("Motorbåd", "Stingray 270 S", 2008, "Rokken", 004, "Volvo Penta 5.0 GXI", 30.0);
            BoatReg.AddBoat("Sejlbåd", "Oceanis 54", 1980, "Jens", 005, "Volvo 50 hk", 54.0);

            Boat tempboat = BoatReg.ReadBoat(003);
            Console.WriteLine($"Type:{tempboat.Type}, Name:{tempboat.Name}");
            BoatReg.DelBoat(003);
            tempboat = BoatReg.ReadBoat(002);
            Console.WriteLine(tempboat);

            MemberRegister MemberRegister = new MemberRegister();
            Member member1 = new Member(001, "Nicolaj", "Nicolajvej 69", "Nicolaj@gmail.com", "78 98 72 63");
            MemberRegister.AddMember(member1);
            Member member2 = new Member(002, "Paw", "Pawgade 420", "Paw@gmail.com", "69 69 69 69");
            MemberRegister.AddMember(member2);
            Member member3 = new Member(003, "Malinda", "Malinda Allé 47", "Malinda@gmail.com", "77 88 99 11 07");
            MemberRegister.AddMember(member3);
            Member member4 = new Member(004, "Lejla", "Lejlastræde 32", "Lejla@gmail.com", " 59 03 77 91");
            MemberRegister.AddMember(member4);
            Member member5 = new Member(005, "Lucas", "Maglegårdsvej 2", "Lucas@gmail.com", "52 30 92 01");
            MemberRegister.AddMember(member5);
            MemberRegister.GetMember(001);


            foreach (Member mem in MemberRegister.PrintMembers().Values)
            {
                Console.WriteLine(mem);
            }

            MemberRegister.DeleteMember(001);

        }        
    }
}

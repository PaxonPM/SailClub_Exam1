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
            Boat boat1 = new PaddleBoat("59 north", 1980,"Skilsmissebåden", 01, 4, 4);
            BoatReg.AddBoat(boat1);
            Boat boat2 = new SailBoat("Laser 200", 1940, "Tøsebåden", 02, 2, 1, 10, 10);
            BoatReg.AddBoat(boat2);
            Boat boat3 = new MotorBoat("Stingray", 1969, "Måneskin", 03, 26, 30, "Yamaha V8, Diesel",300 );
            BoatReg.AddBoat(boat3);
            Boat boat = new SailBoat("Træskib",);
            
           
            Boat tempboat = BoatReg.ReadBoat(003);
            Console.WriteLine($"Type:{tempboat.Model}, Name:{tempboat.Name}");
            BoatReg.DelBoat(003);
            tempboat = BoatReg.ReadBoat(002);
            Console.WriteLine(tempboat);

            MemberRegister MemberRegister = new MemberRegister();
            MemberRegister.CreateMember(003, "Nicolaj", "Nicolajvej 69", "Nicolaj@gmail.com", "78 98 72 63", false);
            MemberRegister.CreateMember(004, "Paw", "Pawgade 420", "Paw@gmail.com", "69 69 69 69", false);
            MemberRegister.CreateMember(005, "Malinda", "Malinda Allé 47", "Malinda@gmail.com", "77 88 99 11 07", false);
            MemberRegister.CreateMember(006, "Lejla", "Lejlastræde 32", "Lejla@gmail.com", " 59 03 77 91", false);
            MemberRegister.CreateMember(007, "Lucas", "Maglegårdsvej 2", "Lucas@gmail.com", "52 30 92 01", true);

        }
    }
}

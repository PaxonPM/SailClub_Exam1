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
            Boat boat4 = new SailBoat("Træskib", 1492, "Santa Maria", 04, 40, 64.3, 4, 300);
            BoatReg.AddBoat(boat4);
                
            Console.WriteLine(BoatReg.ReadBoat(003));
            BoatReg.DelBoat(003);
            tempboat = BoatReg.ReadBoat(002);
            Console.WriteLine(tempboat);

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
          
          
            EventPlanner planner = new EventPlanner();
            Event e1 = planner.CreateEvent("Julefrokost", "12/12", "18:00", 50, "Hyggeaften i klubben");
            Event e2 = planner.CreateEvent("Nytårsaften", "31/12", "21:00", 100, "Nytårsaften i klubben");
            Event e3 = planner.CreateEvent("Bowling aften", "10/02", "20:00", 150, "Bowling aften i klubben");
            Event e4 = planner.CreateEvent("Bingo aften", "14/02", "18:00", 50, "Bingo aften i klubben");
            Member m1 = new Member(1, "Lars", "Adress", "Mail", "Phone");
            e1.AddParticipant(m1);
            e2.AddParticipant(m1);
            e2.RemoveParticipant(m1);
            planner.UpdateEvent(e1, "Julefrokost 2025", "13/12", "19:00", 75, "Opdateret beskrivelse");
            
            foreach (Event ev in planner.ReadAllEvents())
            {
                Console.WriteLine(ev.ToString());
            }
            

           
            BookingOverview bookingOverview = new BookingOverview();
            Booking b1 = bookingOverview.CreateOverview("01/03", "05/03", MemberRegister.ReadMember(003), BoatReg.ReadBoat(001));
            Booking b2 = bookingOverview.CreateOverview("10/04", "12/04", MemberRegister.ReadMember(004), BoatReg.ReadBoat(002));
            Booking b3 = bookingOverview.CreateOverview("20/05", "22/05", MemberRegister.ReadMember(005), BoatReg.ReadBoat(003));
            bookingOverview.UpdateDato(b1, "02/03", "06/03");
            bookingOverview.DeleteBooking(b2);
            foreach (Booking booking in bookingOverview.ReadAll())
            {
                Console.WriteLine(booking.ToString()); 
            }
                

        }
    }
}

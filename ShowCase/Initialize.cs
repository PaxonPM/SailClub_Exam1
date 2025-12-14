using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ClassLibSailClub;
public static class Initialize
{
    public static void Start()
    {

        // boat showcase;
        Console.WriteLine("-------------------------------------------------------\nBOATSHOWCASE");
        Console.WriteLine($"Initializing Boat Registration...");
        BoatReg BoatReg = new BoatReg();
        Console.WriteLine($"Creating boat objects...");
        Boat boat1 = new PaddleBoat("59 north", 1980,"Skilsmissebåden", 01, 4, 4, false, 2);
        Boat boat2 = new SailBoat("Laser 200", 1940, "Tøsebåden", 02, 2, 1, 10, 10);
        Boat boat3 = new MotorBoat("Stingray", 1969, "Måneskin", 03, 26, 30, "Yamaha V8, Diesel",300 );
        Boat boat4 = new SailBoat("Træskib", 1492, "Santa Maria", 04, 40, 64.3, 4, 300);

        Console.WriteLine("Done creating boat objects.\nNow Adding Boat objects to boatregister");
        BoatReg.CreateBoat(boat1);
        BoatReg.CreateBoat(boat2);
        BoatReg.CreateBoat(boat3);
        BoatReg.CreateBoat(boat4);
        Console.WriteLine("Done adding boats to register.\nNow Reading Boat objects from boatregister");

        Console.WriteLine($"Read boat:\n{BoatReg.ReadBoat(3).ToString()}");
        Console.WriteLine($"Deleted boat:\n{BoatReg.DeleteBoat(3).ToString()}");
        Console.WriteLine("Printing all boats in list:");
        foreach (Boat boat in BoatReg.PrintBoats())
        {
            Console.WriteLine(boat.ToString());
        }
        ////////////////////////////////////////////////
        // member showcase
        Console.WriteLine("\n\n-------------------------------------------------------\nMEMBER SHOWCASE");


        Console.WriteLine($"\n\nInitializing Member Registration...");
        var memberRegisterObj = new MemberRegister();
        Console.WriteLine($"Creating member objects...");
        Person member1 = new Member(1, "Nicolaj", "Nicolajvej 69", "Nicolaj@gmail.com", "78 98 72 63");
        Person member2 = new Member(2, "Paw", "Pawgade 420", "Paw@gmail.com", "69 69 69 69");
        Person member3 = new Member(3, "Malinda", "Malinda Allé 47", "Malinda@gmail.com", "77 88 99 11 07");
        Person member4 = new Member(4, "Lejla", "Lejlastræde 32", "Lejla@gmail.com", " 59 03 77 91");
        Person member5 = new Member(5, "Lucas", "Maglegårdsvej 2", "Lucas@gmail.com", "52 30 92 01");
        Person admin1 = new Admin(6, "Bossman", "bossroad 1", "Bossman@gmail.com", "52 30 92 01");


        Console.WriteLine("Done creating member objects.\nNow Adding Member objects to memberregister");
        memberRegisterObj.CreateMember(member1);
        memberRegisterObj.CreateMember(member2);
        memberRegisterObj.CreateMember(member3);
        memberRegisterObj.CreateMember(member4);
        memberRegisterObj.CreateMember(member5);
        memberRegisterObj.CreateMember(admin1);

        Console.WriteLine("Done adding members to register.\nNow Reading Member objects from memberregister");
        Console.WriteLine($"Read member:\n{memberRegisterObj.ReadMember(1).ToString()}");
        Console.WriteLine($"Deleted member:\n{memberRegisterObj.DeleteMember(1).ToString()}");
        
        Console.WriteLine("Printing all members in list:");
        foreach (Person mem in memberRegisterObj.PrintMembers().Values)
        {
            Console.WriteLine(mem);
        }
        ///////////////////////////////////////////////
        /// Event showcase
        Console.WriteLine("\n\n-------------------------------------------------------\nEVENT SHOWCASE");
        Console.WriteLine("\n\nInitializing Event Registration...");
        EventPlanner planner = new EventPlanner();

        Console.WriteLine("Create event objects...");
        Event e1 = new Event("Julefrokost", "12/12", "18:00", 50, "Hyggeaften i klubben");
        Event e2 = new Event("Nytårsaften", "31/12", "21:00", 100, "Nytårsaften i klubben");
        Event e3 = new Event("Bowling aften", "10/02", "20:00", 150, "Bowling aften i klubben");
        Event e4 = new Event("Bingo aften", "14/02", "18:00", 50, "Bingo aften i klubben");

        Console.WriteLine("Done creating event objects.\nNow Adding Event objects to eventplanner");
        planner.CreateEvent(e1);
        planner.CreateEvent(e2);
        planner.CreateEvent(e3);
        planner.CreateEvent(e4);

        Console.WriteLine("Adding participants to events...");
        e1.AddParticipant(member4);
        e2.AddParticipant(member5);
        e2.AddParticipant(member3);
        e2.AddParticipant(member2);
        Console.WriteLine("Done adding participants.\nNow updating and removing participants and events...");
        e2.RemoveParticipant(member3);
        planner.UpdateEvent(e1, "Julefrokost 2025", "13/12", "19:00", 75, "Opdateret beskrivelse");

        Console.WriteLine("Done updating and removing participants and events.\nNow printing all events in eventplanner:");

        foreach (Event ev in planner.PrintAllEvents())
        {
            Console.WriteLine(ev.ToString());
        }
        ///////////////////////////////////////////////
        
        // Booking showcase
        Console.WriteLine("\n\n-------------------------------------------------------\nBOOKING SHOWCASE");
        Console.WriteLine("Creating booking register amd booking objects");
        BookingOverview bookingOverview = new BookingOverview();
        Booking b1 = new Booking("01/03", "05/03", memberRegisterObj.ReadMember(3), BoatReg.ReadBoat(1));
        Booking b2 = new Booking("10/04", "12/04", memberRegisterObj.ReadMember(4), BoatReg.ReadBoat(2));
        Booking b3 = new Booking("20/05", "22/05", memberRegisterObj.ReadMember(5), BoatReg.ReadBoat(3));

        Console.WriteLine("Adding booking objects to booking register");
        bookingOverview.CreateBooking(b1);
        bookingOverview.CreateBooking(b2);
        bookingOverview.CreateBooking(b3);

        Console.WriteLine("Updating and deleting bookings in booking register");
        bookingOverview.UpdateDato(b1, "02/03", "06/03");
        bookingOverview.DeleteBooking(b2);

        Console.WriteLine("Printing all bookings in booking register:");
        foreach (Booking booking in bookingOverview.PrintAll())
        {
            Console.WriteLine(booking.ToString()); 
        }
                

    }
}


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
        
        #region Boat
        
        // boat showcase;
        Console.WriteLine("-------------------------------------------------------\nBOATSHOWCASE");
        Console.WriteLine($"Initializing Boat Registration...");
        BoatReg BoatReg = new BoatReg();
        Console.WriteLine($"Creating boat objects...");
        Boat[] boats = new Boat[5];
        boats[0] = new PaddleBoat("59 north", 1980, "Skilsmissebåden", 01, 4, 4, false, 2);
        boats[1] = new SailBoat("Laser 200", 1940, "Tøsebåden", 02, 2, 1, 10, 10);
        boats[2] = new MotorBoat("Stingray", 1969, "Måneskin", 03, 26, 30, "Yamaha V8, Diesel",300 ); //
        boats[3] = new SailBoat("", 1492, "Santa Maria", 04, 40, 64.3, 4, 300);
        boats[4] = new SailBoat("ErrorBoat", 1492, "Errorcatch", 04, 40, 64.3, 0, 300);
        Console.WriteLine("Done creating boat objects.\nNow Adding Boat objects to boatregister");

        foreach (Boat b in boats)
        {
            TryAddBoat(BoatReg, b);
        }

        Console.WriteLine("Done adding boats to register.\nNow Reading Boat objects from boatregister");
        Boat? readBoat = BoatReg.ReadBoat(3);
        if (readBoat != null)
            Console.WriteLine($"Read boat:\n{readBoat.ToString()}");
        else
            Console.WriteLine("Read boat:\nBoat not found.");
        
        readBoat = BoatReg.DeleteBoat(1);
        if (readBoat != null)
            Console.WriteLine($"Deleted boat:\n{readBoat.ToString()}");
        else
            Console.WriteLine("Boat not found.");

        Console.WriteLine("Printing all boats in list:");
        foreach (Boat boat in BoatReg.PrintBoats())
        {
            Console.WriteLine(boat.ToString());
        }
        #endregion Boat
        ////////////////////////////////////////////////
        ///
        #region Member
        // member showcase
        Console.WriteLine("\n\n-------------------------------------------------------\nMEMBER SHOWCASE");


        Console.WriteLine($"\n\nInitializing Member Registration...");
        var memberRegisterObj = new MemberRegister();
        Console.WriteLine($"Creating member objects...");

        Person[] members = new Person[8];
        members[0] = new Member(1, "Nicolaj", "Nicolajvej 69", "Nicolaj@gmail.com", "78 98 72 63");
        members[1] = new Member(2, "Paw", "Pawgade 420", "Paw@gmail.com", "69 69 69 69");
        members[2] = new Member(2, "Paw", "Pawgade 420", "Paw@gmail.com", "69 69 69 69");
        members[3] = new Member(3, "Malinda", "Malinda Allé 47", "Malinda@gmail.com", "77 88 99 11 07");
        members[4] = new Member(4, "Lejla", "Lejlastræde 32", "Lejla@gmail.com", " 59 03 77 91");
        members[5] = new Member(5, "Lucas", "Maglegårdsvej 2", "Lucas@gmail.com", "52 30 92 01");
        members[6] = new Member(6, "Lucas", "Maglegårdsvej 2", "Lucas@gmail.com", "52 30 92 01"); // error catch
        members[7] = new Admin(6, "AdminGuy", "Adminstreet 5", "Bossman@gmail.com", "52 30 92 01");


        Console.WriteLine("Done creating member objects.\nNow Adding Member objects to memberregister");

        foreach (Person p in members)
        {
            TryAddPerson(memberRegisterObj, p);
        }
        



        Console.WriteLine("Done adding members to register.\nNow Reading Member objects from memberregister");
        Console.WriteLine($"Read member:\n{memberRegisterObj.ReadMember(2).ToString()}");
        Console.WriteLine($"Deleted member:\n{memberRegisterObj.DeleteMember(1).ToString()}");
        
        Console.WriteLine("Printing all members in list:");
        foreach (Person mem in memberRegisterObj.PrintMembers().Values)
        {
            Console.WriteLine(mem);
        }
        #endregion Member
        ///////////////////////////////////////////////
        #region Event
        /// Event showcase
        Console.WriteLine("\n\n-------------------------------------------------------\nEVENT SHOWCASE");
        Console.WriteLine("\n\nInitializing Event Registration...");
        EventPlanner planner = new EventPlanner();

        Console.WriteLine("Create event objects...");
        Event e1 = new Event("Julefrokost", "12/12", "18:00", 50, "Hyggeaften i klubben");
        Event e2 = new Event("Nytårsaften", "31/12", "21:00", 100, "Nytårsaften i klubben");
        Event e3 = new Event("Bowling aften", "10/02", "20:00", 150, "Bowling aften i klubben");
        Event e4 = new Event("Bingo aften", "14/02", "18:00", 50, "Bingo aften i klubben");
        Event e5 = new Event("", "14/02", "18:00", 50, "Bingo aften i klubben");

        Console.WriteLine("Done creating event objects.\nNow Adding Event objects to eventplanner");
        planner.CreateEvent(e1);
        planner.CreateEvent(e2);
        planner.CreateEvent(e3);
        planner.CreateEvent(e4);
        try
        {
            planner.CreateEvent(e5); // error catch
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine("Adding participants to events...");
        e1.AddParticipant(members[3]);
        e2.AddParticipant(members[4]);
        e2.AddParticipant(members[2]);
        e2.AddParticipant(members[1]);
        Console.WriteLine("Done adding participants.\nNow updating and removing participants and events...");
        e2.RemoveParticipant(members[2]);
        planner.UpdateEvent(e1, "Julefrokost 2025", "13/12", "19:00", 75, "Opdateret beskrivelse");

        Console.WriteLine("Done updating and removing participants and events.\nNow printing all events in eventplanner:");

        foreach (Event ev in planner.PrintAllEvents())
        {
            Console.WriteLine(ev.ToString());
        }
        #endregion Event
        ///////////////////////////////////////////////
        #region Booking
        // Booking showcase
        Console.WriteLine("\n\n-------------------------------------------------------\nBOOKING SHOWCASE");
        Console.WriteLine("Creating booking register amd booking objects");
        BookingOverview bookingOverview = new BookingOverview();
        Booking b1 = new Booking("01/03", "05/03", memberRegisterObj.ReadMember(3), BoatReg.ReadBoat(1));
        Booking b2 = new Booking("10/04", "12/04", memberRegisterObj.ReadMember(4), BoatReg.ReadBoat(2));
        Booking b3 = new Booking("20/05", "22/05", memberRegisterObj.ReadMember(5), BoatReg.ReadBoat(3));
        Booking b4 = new Booking("", "22/05", memberRegisterObj.ReadMember(5), BoatReg.ReadBoat(3)); // error catch

        Console.WriteLine("Adding booking objects to booking register");
        bookingOverview.CreateBooking(b1);
        bookingOverview.CreateBooking(b2);
        bookingOverview.CreateBooking(b3);
        try
        {
            bookingOverview.CreateBooking(b4);

        }
        catch (Exception ex)
        {

            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine("Updating and deleting bookings in booking register");
        bookingOverview.UpdateDato(b1, "02/03", "06/03");
        bookingOverview.DeleteBooking(b2);

        Console.WriteLine("Printing all bookings in booking register:");
        foreach (Booking booking in bookingOverview.PrintAll())
        {
            Console.WriteLine(booking.ToString()); 
        }
        #endregion Booking
        //////////////////////////////////////////////
        ///
         #region Blog
        // Blog post showcase

        Console.WriteLine("\n\n-------------------------------------------------------\nBLOG POST SHOWCASE");
        Console.WriteLine("Creating blog post register and blog post objects");
        BlogCollection blogRegister = new BlogCollection();
        BlogPost[] BlogReg = new BlogPost[5];

        BlogReg[0] = new BlogPost("Velkommen til SailClub", "Dette er den første blogpost på SailClub!");
        BlogReg[1] = new BlogPost("Sommerfest 2024", "Husk at tilmelde jer til sommerfesten i år!");
        BlogReg[2] = new BlogPost("Nye både ankommet", "Vi har netop modtaget flere nye både til klubben. Kom forbi og se dem!");
        BlogReg[3] = new BlogPost("Vinterevent", "Tilmeld dig vores vinterevent og nyd en sjov aften med aktiviteter!");
        BlogReg[4] = new BlogPost("Gode råd til sejlads", "Få tips til en sikker og sjov sejladsoplevelse.");
        
        Console.WriteLine("Done creating blog post objects.\nNow Adding Blog Post objects to blog post register");
        foreach (BlogPost bp in BlogReg)
        {
            TryAddBlog(blogRegister, bp, members[7]); // Admin user creating blog posts
        }
        Console.WriteLine("Done adding blog posts to register.\nNow reading a blog post from blog post register");
        BlogPost readPost = blogRegister.ReadBlogPost("Sommerfest 2024");
        if (readPost != null)
            Console.WriteLine($"Read boat:\n{readPost.ToString()}");
        else
            Console.WriteLine("Read post:\npost not found.");

        blogRegister.DeleteBlogPost(members[7], "Vinterevent");
        Console.WriteLine("Printing all blog posts in blog post register:");
        foreach (BlogPost post in BlogReg)
        {
            Console.WriteLine(post.ToString());
        }

        #endregion Blog 

    }

    private static void TryAddBoat(BoatReg reg, Boat b)
    {
        string errorMsg = "Error(constraints): Boat creation failed due to validation errors.";
        string successMsg = "Boat creation succeeded for " + b.Name;
        try
        {
            Console.WriteLine(reg.CreateBoat(b) == null ? errorMsg : successMsg);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error(exception): {ex.Message}");
        }
    }
    private static void TryAddPerson(MemberRegister reg, Person p)
    {
        
        try
        {
            reg.CreateMember(p);
            Console.WriteLine($"Member {p.Id} added successfully.");
            
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error(exception): {ex.Message}");
        }
    }
    private static void TryAddBlog(BlogCollection blog, BlogPost bp, Person person)
    {
        string errorMsg = "Error(constraints): Blog creation failed due to validation errors.";
        string successMsg = "Blog creation succeeded for " + bp.Title;
        try
        {
            Console.WriteLine(blog.CreateBlogPost(person, bp) == null ? errorMsg : successMsg);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error(exception): {ex.Message}");
        }
    }

}


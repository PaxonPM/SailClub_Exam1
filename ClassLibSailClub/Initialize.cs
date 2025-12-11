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
            MemberRegister.CreateMember(003, "Nicolaj", "Nicolajvej 69", "Nicolaj@gmail.com", "78 98 72 63", false);
            MemberRegister.CreateMember(004, "Paw", "Pawgade 420", "Paw@gmail.com", "69 69 69 69", false);
            MemberRegister.CreateMember(005, "Malinda", "Malinda Allé 47", "Malinda@gmail.com", "77 88 99 11 07", false);
            MemberRegister.CreateMember(006, "Lejla", "Lejlastræde 32", "Lejla@gmail.com", " 59 03 77 91", false);
            MemberRegister.CreateMember(007, "Lucas", "Maglegårdsvej 2", "Lucas@gmail.com", "52 30 92 01", true);

           
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

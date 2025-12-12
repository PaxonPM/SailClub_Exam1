namespace ClassLibSailClub;

public class BookingOverview
{

    public List<Booking> BookingList { get; set; } //Lister til booking og events

    public BookingOverview() //constructor
    {
        BookingList = new List<Booking>();
    }

    //Method
    public Booking CreateOverview(string datoStart, string datoSlut, Member member, Boat boat)
    {
        if (string.IsNullOrEmpty(datoStart))
            throw new ArgumentException("The input was null or empty");


        Booking bookingOverview = new Booking(datoStart, datoSlut, member, boat);
        BookingList.Add(bookingOverview);

        return bookingOverview;

    }

    public void DeleteBooking(Booking bookingToDelete)
    {
        if (!BookingList.Remove(bookingToDelete))
        {
            throw new KeyNotFoundException("bookingen blev ikke fundet i kalenderen.");
        }
    }
    
    public string UpdateDato(Booking booking, string nyStart, string nySlut)
    {
        if (booking == null)
            throw new ArgumentException("Booking må ikke være null.");

        return booking.UpdateDato(nyStart, nySlut);
    }
    
    public List<Booking> ReadAll()
    {
        return BookingList;
    }
}



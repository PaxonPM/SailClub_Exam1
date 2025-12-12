namespace ClassLibSailClub;

public class BookingOverview
{

    public List<Booking> BookingList { get; set; } //Lister til booking og events

    public BookingOverview() //constructor
    {
        BookingList = new List<Booking>();
    }

    //Method
    public Booking CreateBooking(Booking booking)
    {
        if (string.IsNullOrEmpty(booking.DatoStart))
            throw new ArgumentException("The input was null or empty");

        BookingList.Add(booking);

        return booking;

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



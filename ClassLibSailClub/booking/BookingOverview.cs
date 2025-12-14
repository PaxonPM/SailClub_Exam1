namespace ClassLibSailClub;

public class BookingOverview
{

    public List<Booking> BookingList { get; set; } = new List<Booking>();//Lister til booking og events

    //Method
    public Booking CreateBooking(Booking booking)
    {
        if (string.IsNullOrEmpty(booking.DatoStart))
            throw new ArgumentException("The input was null or empty");

        BookingList.Add(booking);

        return booking;

    }
    public Booking UpdateDato(Booking booking, string nyStart, string nySlut)
    {
        if (booking == null)
            throw new ArgumentException("Booking må ikke være null.");

        return booking;
    }
    public Booking DeleteBooking(Booking bookingToDelete)
    {
        if (!BookingList.Remove(bookingToDelete))
        {
            throw new KeyNotFoundException("bookingen blev ikke fundet i kalenderen.");
        }

        return bookingToDelete;
    }
    
    
    public List<Booking> PrintAll()
    {
        return BookingList;
    }
}



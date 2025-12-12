
namespace ClassLibSailClub;

public class EventPlanner
{
    //Liste til events
    public List<Event> EventList { get; set; }

    public EventPlanner() //constructor
    {
        EventList = new List<Event>();
    }

    //Method
    public Event CreateEvent(string name, string date, string time, int price, string description)
    {
        if(string.IsNullOrEmpty(name))
            throw new ArgumentException("The input was null or empty");
                    
                
        Event newEvent = new Event(name, date, time, price, description);
        EventList.Add(newEvent);
        return newEvent; // Hvis alt lykkes, returneres det oprettede event
        
    }

    public void DeleteEvent(Event eventToDelete) 
    {
        if (!EventList.Remove(eventToDelete))
        {
            throw new KeyNotFoundException("Eventet blev ikke fundet i kalenderen.");
        }
    }

    public void UpdateEvent(Event eventToUpdate, string name, string date, string time, int price, string description)
    {
        if (!EventList.Contains(eventToUpdate))
        {
            throw new KeyNotFoundException("Eventet blev ikke fundet i kalenderen.");
        }

        eventToUpdate.Name = name;
        eventToUpdate.Date = date;
        eventToUpdate.Time = time;
        eventToUpdate.Price = price;
        eventToUpdate.Description = description;
        
    }
    public List<Event> ReadAllEvents()

    {
        return EventList;
    }
}



namespace ClassLibSailClub
{
    public class EventPlanner
    {
        //Liste til events
        public List<Event> EventList { get; set; } = new List<Event>();

        //Method
        public Event CreateEvent(Event tempEvent)
        {
            if (tempEvent== null)
                throw new ArgumentException("The input was null");

            EventList.Add(tempEvent);
            return tempEvent; // Hvis alt lykkes, returneres det oprettede event

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
        public void DeleteEvent(Event eventToDelete)
        {
            if (!EventList.Remove(eventToDelete))
            {
                throw new KeyNotFoundException("Eventet blev ikke fundet i kalenderen.");
            }
        }


        public List<Event> PrintAllEvents()

        {
            return EventList;
        }
    }
}



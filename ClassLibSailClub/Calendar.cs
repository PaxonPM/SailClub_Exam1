using ClassLibSailClub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibSailClub
{
    public class Calendar
    {
        public List<Booking> BookingList { get; set; } //Liste
        public List<Event> EventList { get; set; }

        public Calendar() //constructor
        {
            BookingList = new List<Booking>();
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
    }
}
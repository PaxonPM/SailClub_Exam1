using ClassLibSailClub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibSailClub
{
    public class Calendar
    {
        public List<Booking> BookingListe { get; set; } //Liste
        public List<Event> EventListe { get; set; }

        public Calendar() //constructor
        {
            BookingListe = new List<Booking>();
            EventListe = new List<Event>();
        }

        //Method
        public event CreateEvent (string navn, string dato, string tid, int pris, string beskrivelse)
        {
            Event nytEvent = new Event(navn, dato, tid, pris, beskrivelse);
        EventListe.Add(nytEvent);
            return nytEvent; 
        }

}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class Event
    {
        public string Name { get; set; } //Properties
        public string Date { get; set; }
        public string Time { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public List<Member> ParticipantList { get; set; }
        public Event(string name, string date, string time, int price, string description)

        {
            Name = name; //Constructor
            Date = date;
            Time = time;
            Price = price;
            Description = description;
            ParticipantList = new List<Member>();
        }

        public void AddParticipant(Member Participant) //Method
        {

            if (Participant == null)
                throw new ArgumentException("Argument er null i add deltager");

            ParticipantList.Add(Participant); // Forsøger at tilføje deltager
            //return true; // Hvis det lykkes, returneres true

        }

        public Member RemoveParticipant(Member participant)
        {
            if (participant == null)
                throw new ArgumentException("Argument er null i Remove deltager");
                
            ParticipantList.Remove(participant);
            return participant;
        }
    }
}



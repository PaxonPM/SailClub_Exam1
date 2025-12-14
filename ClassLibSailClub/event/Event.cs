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
        public List<Person> ParticipantList { get; set; } = new List<Person>();
        public Event(string name, string date, string time, int price, string description)

        {
            Name = name; //Constructor
            Date = date;
            Time = time;
            Price = price;
            Description = description;
        }

        public Person AddParticipant(Person Participant) //Method
        {

            if (Participant == null)
                throw new ArgumentException("Argument er null i add deltager");

            ParticipantList.Add(Participant); 
            return Participant;

        }

        public Person RemoveParticipant(Person participant)
        {
            if (participant == null)
                throw new ArgumentException("Argument er null i Remove deltager");
                
            ParticipantList.Remove(participant);
            return participant;
        }

        public override string ToString()
        {
            string participantsText = "";
            foreach (var p in ParticipantList)
            {
                participantsText += p.ToString() + "\n";
            }

            return $"-------------------\n" +
                   $"Name:{Name}, Date:{Date}, Time:{Time}, Price:{Price}, Description:{Description} " +
                   $"ParticipantList:\n {participantsText}";
        }
    }
}



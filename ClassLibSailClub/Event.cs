using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class Event
    {
        public string Navn { get; set; } //Properties
        public string Dato { get; set; }
        public string Tid { get; set; }
        public int Pris { get; set; }
        public string Beskrivelse { get; set; }
        public List<Medlem> DeltagerListe { get; set; }

        public Event(string navn, string dato, string tid, int pris, string beskrivelse)

        {
            Navn = navn; //Constructor
            Dato = dato;
            Tid = tid;
            Pris = pris;
            Beskrivelse = beskrivelse;
            DeltagerListe = new List<Medlem>();
        }

        public void AddDeltager(Medlem deltager) //Method
        {
            DeltagerListe.Add(deltager);
        }

        public void RemoveDeltager(Medlem deltager)
        {
            DeltagerListe.Remove(deltager);
        }

    }
}
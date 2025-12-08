using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub

{
    public class Booking // propperties
    {
        public string datoStart { get; set; }
        public string datoSlut { get; set; }
        public Member member { get; set; }
        public Boat boat { get; set; }

        public Booking(string datoStart, string datoSlut, Member member, Boat boat) //constructor 

        {
            this.datoStart = datoStart;
            this.datoSlut = datoSlut;
            this.member = member;
            this.boat = boat;
        }

        public void updateDato(string nyStart, string nySlut) //Method
        {
            this.datoStart = nyStart;
            this.datoSlut = nySlut;
            //return datoStart + "_" + datoSlut; // "_" bruges som adskiller mellem start- og slutdato
        }

    }

}




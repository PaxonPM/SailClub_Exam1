using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


{
    internal class Booking // propperties
    {
        public string datoStart { get; set; }
        public string datoSlut { get; set; }
        public Medlem medlem { get; set; }
        public Boat boat { get; set; }

        public Booking(string datoStart, string datoSlut, Medlem medlem, Boat boat) //constructor 

        {
            this.datoStart = datoStart;
            this.datoSlut = datoSlut;
            this.medlem = medlem;
            this.boat = boat;
        }

        public void updateDato(string nyStart, string nySlut) //Method
        {
            this.datoStart = nyStart;
            this.datoSlut = nySlut;
            return datoStart + "_" + datoSlut; // "_" bruges som adskiller mellem start- og slutdato
        }

    }

}




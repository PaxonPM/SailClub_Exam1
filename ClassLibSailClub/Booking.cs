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

        public Booking(string datoStart, string datoSlut, Medlem medlem, Boat boat)
        {
            try
            {
                if (datoStart == null || datoSlut == null)
                    throw new Exception();

                if (medlem == null || boat == null)
                    throw new Exception();

                DatoStart = datoStart;
                DatoSlut = datoSlut;
                Medlem = medlem;
                Boat = boat;
            }
            catch
            {
                DatoStart = null;
                DatoSlut = null;
                Medlem = null;
                Boat = null;
            }
        }
        

        public string UpdateDato(string nyStart, string nySlut)
        {
            try
            {
                if (nyStart == null || nySlut == null)
                    throw new Exception();

                DatoStart = nyStart;
                DatoSlut = nySlut;

                return DatoStart + "_" + DatoSlut;
            }
            catch
            {
                return null;
            }
        }
    }
}

}





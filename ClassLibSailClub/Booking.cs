using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub

{
    public class Booking // propperties
    {
        public string DatoStart { get; set; }
        public string DatoSlut { get; set; }
        public Member Member { get; set; }
        public Boat Boat { get; set; }

        public Booking(string datoStart, string datoSlut, Member member, Boat boat)
        {
            try
            {
                if (datoStart == null || datoSlut == null)
                    throw new Exception();

                if (member == null || boat == null)
                    throw new Exception();

                DatoStart = datoStart;
                DatoSlut = datoSlut;
                Member = member;
                Boat = boat;
            }
            catch
            {
                DatoStart = null;
                DatoSlut = null;
                Member = null;
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






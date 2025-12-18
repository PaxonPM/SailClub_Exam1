namespace ClassLibSailClub

{
    public class Booking // propperties
    {
        public string DatoStart { get; set; }
        public string DatoSlut { get; set; }
        public Person Member { get; set; }
        public Boat Boat { get; set; }

        public Booking(string datoStart, string datoSlut, Person member, Boat boat)
        {
            DatoStart = datoStart;
            DatoSlut = datoSlut;
            Member = member;
            Boat = boat;
        }
        
        public string UpdateDate(string nyStart, string nySlut)
        {
            if (nyStart == null || nySlut == null)
                    throw new Exception();

            DatoStart = nyStart;
            DatoSlut = nySlut;

            return DatoStart + "_" + DatoSlut;
        }

        public override string ToString()
        {
            return $"DatoStart:{DatoStart}, DatoSlut:{DatoSlut}, Member:{Member}, Boat:{Boat}"; 
        }

        }
    }







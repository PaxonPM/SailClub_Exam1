using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class BoatReg
    {
        List<Boat> Boats { get; set; } = new List<Boat>
        {

        };
        public BoatReg()
        {

        }

        public void AddBoat(string type, string model, int year, string name, int sailNum, string motorInf, double length)
        {
            Boat tempObj = new Boat(type, model, year, name, sailNum, motorInf, length);
            Boats.Add(tempObj);
        }

        public void DelBoat(int sailNum)
        {
            foreach (Boat boat in Boats)
            {
                if (boat.SailNum == sailNum)
                {
                    Boats.Remove(boat);
                }
            }
        }

        public void UpdBoat(int sailNum)
        {

        }

        public void ReadBoat(int sailNum)
        {

        }
    }

}

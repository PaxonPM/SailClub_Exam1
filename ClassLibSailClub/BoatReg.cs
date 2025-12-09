using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class BoatReg 

    {
        List<Boat> Boats { get; set; } = new List<Boat>();
        public BoatReg()
        {

        }

        public void AddBoat(string type, string model, int year, string name, int sailNum, string motorInf, double length)
        {
            Boat tempObj = new Boat(type, model, year, name, sailNum, motorInf, length);
            Boats.Add(tempObj);
        }

        public Boat DelBoat(int sailNum)
        {
            foreach (Boat boat in Boats)
            {
                    if (boat.SailNum == sailNum)
                    {
                        Boats.Remove(boat);
                        return boat;
                    }
            }
            return null;
        }

        public string UpdDam(int sailNum, string damage)
        {
            foreach (Boat boat in Boats)
            {
                if (boat.SailNum == sailNum)
                {
                    boat.AddDamage(damage);
                }
            }
            return null;
        }

        public void UpdateRepair(int sailNum, int damageLogId)
        {
            foreach (Boat boat in Boats)
            {
                if (boat.SailNum == sailNum)
                {
                    boat.Repair(damageLogId);
                }
            }
        }

        public Boat ReadBoat(int sailNum)
        {
            foreach (Boat boat in Boats)
            {
                if (boat.SailNum == sailNum)
                {
                    return boat;
                }


            }

            return null;
        }
    }
}

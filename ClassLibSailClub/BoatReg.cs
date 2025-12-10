using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class BoatReg  : IBoatRegister

    {
        public List<Boat> Boats { get; private set; } = new List<Boat>();
       
       

        public void AddBoat(string type, string model, int year, string name, int sailNum, string motorInf, double length)
        {
            Boats.Add(new Boat(type, model, year, name, sailNum, motorInf, length));
            //Boat tempObj = new Boat(type, model, year, name, sailNum, motorInf, length);
            //Boats.Add(tempObj);
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

        public Boat UpdDam(int sailNum, string damage)
        {
            foreach (Boat boat in Boats)
            {
                if (boat.SailNum == sailNum)
                {
                    boat.Maintenance.AddDamage(damage);
                    return boat;
                }
            }
            return null;
        }

        public Boat UpdateRepair(int sailNum, int damageLogId)
        {
            foreach (Boat boat in Boats)
            {
                if (boat.SailNum == sailNum)
                {
                    boat.Maintenance.Repair(damageLogId);
                    return boat;
                }

            }
            return null;
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

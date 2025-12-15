using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class BoatReg : IBoatRegister

    {
        public List<Boat> Boats { get; private set; } = new List<Boat>();
       
        public Boat? CreateBoat(Boat tempBoat)
        {
            tempBoat.Validate();

            if (!tempBoat.RoutineValidate())
            { 
                return null;
            }
            Boats.Add(tempBoat);
            return tempBoat;
        }

        public Boat? ReadBoat(int sailNum)
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
        public Boat? UpdateBoatDamage(int sailNum, string damage)
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

        public Boat? UpdateBoatRepair(int sailNum, int damageLogId)
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
        public Boat? DeleteBoat(int sailNum)
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

        public List<Boat> PrintBoats()
        {
            return Boats;
        }

    }
}

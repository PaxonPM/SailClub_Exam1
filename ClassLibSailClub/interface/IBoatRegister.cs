using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public interface IBoatRegister
    {
        List<Boat> Boats { get; }

        Boat? CreateBoat(Boat tempBoat);
        Boat? ReadBoat(int sailNum);
        Boat? UpdateBoatDamage(int sailNum, string damage);
        Boat? UpdateBoatRepair(int sailNum, int damageLogId);
        Boat? DeleteBoat(int sailNum);

    }
}

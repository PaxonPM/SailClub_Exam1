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

        void AddBoat(string type, string model, int year, string name, int sailNum, string motorInf, double length);
        Boat DelBoat(int sailNum);
        Boat UpdDam(int sailNum, string damage);
        Boat UpdateRepair(int sailNum, int damageLogId);
        Boat ReadBoat(int sailNum);

    }
}

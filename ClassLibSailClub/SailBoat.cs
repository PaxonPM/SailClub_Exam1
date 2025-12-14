using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class SailBoat : Boat
    {
        public int NumberOfSails { get; set; }
        public double SailSizeM2 { get; set; }
        public SailBoat(string model, int year, string name, int sailNum, int capacity, double length, int numberOfSails, int sailSizeM2 )
        : base(model, year, name, sailNum, capacity, length)
        {
            NumberOfSails = numberOfSails;
            SailSizeM2 = sailSizeM2;
        }
        
    }
           
}



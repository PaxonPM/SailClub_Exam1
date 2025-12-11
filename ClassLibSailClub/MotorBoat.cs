using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class MotorBoat : Boat
    {
        public MotorBoat(string model, int year, string name, int sailNum, int capacity, double length)
       : base(model, year, name, sailNum, capacity, length)
        {

        }

        public int NumberOfSails { get; set; }
        public double SailSizeM2 { get; set; }

      //  public MotorBoat(string model, int year, string name, int sailNum, int capacity, double length, int numberOfSails, double sailSizeM2)
        //{
          //  NumberOfSails = numberOfSails;
            //SailSizeM2 = sailSizeM2;
        //}
    }
}

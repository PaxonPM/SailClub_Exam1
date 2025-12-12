using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class MotorBoat : Boat
    {
        public string MotorInf { get; set; }
        public double HorsePower { get; set; }
        public MotorBoat(string model, int year, string name, int sailNum, int capacity, double length, string motorInf, double horsePower)
       : base(model, year, name, sailNum, capacity, length)
        {
            MotorInf = motorInf;
            HorsePower = horsePower;
        }

       

      //  public MotorBoat(string model, int year, string name, int sailNum, int capacity, double length, int numberOfSails, double sailSizeM2)
        //{
          //  NumberOfSails = numberOfSails;
            //SailSizeM2 = sailSizeM2;
        //}
    }
}

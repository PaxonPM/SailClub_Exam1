using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class Boat : Maintenance
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public int SailNum { get; set; }
        public string MotorInf { get; set; }
        public double Length { get; set; }

        public Boat(string type, string model, int year, string name, int sailNum, string motorInf, double length)
        {
            Type = type;
            Model = model;
            Name = name;
            SailNum = sailNum;
            MotorInf = motorInf;
            Length = length;
        }


    }
}

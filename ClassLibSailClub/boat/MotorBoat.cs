using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class MotorBoat : Boat, IValidate
    {
        public string MotorInf { get; set; }
        public double HorsePower { get; set; }

        public MotorBoat(string model, int year, string name, int sailNum, int capacity, double length, string motorInf, double horsePower)
       : base(model, year, name, sailNum, capacity, length)
        {
            MotorInf = motorInf;
            HorsePower = horsePower;
        }

        public override void Validate()
        {
            base.Validate();

            if (string.IsNullOrWhiteSpace(MotorInf))
            {
                throw new ArgumentException("Motor information cannot be null or empty.");
            }
            if (HorsePower <= 0)
            {
                throw new ArgumentException("Horse power must be a positive number.");
            }
        }

        public override bool TryValidate()
        {
            if (!base.TryValidate()) return false;
            if (HorsePower > 500) return false;
            if (MotorInf.Length < 5) return false;
            return true;

        }

    }
}

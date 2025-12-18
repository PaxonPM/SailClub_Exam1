using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class PaddleBoat : Boat
    {
        public bool IsInflatable { get; set; }
        public int NumberOfPaddles { get; set; }
        public PaddleBoat(string model, int year, string name, int sailNum, int capacity, double length, bool isInflatable, int numberOfPaddles)
       : base(model, year, name, sailNum, capacity, length)
        {
            IsInflatable = isInflatable;
            NumberOfPaddles = numberOfPaddles;
            
        }
        public override string ToString()
        {
            return $"{base.ToString()} \n Is Inflatable: {IsInflatable} \n Number of Paddles: {NumberOfPaddles}";
        }
        public override void Validate()
        {
            base.Validate();
        }

        public override bool RoutineValidate()
        {
            if (!base.RoutineValidate()) return false;
            if (NumberOfPaddles < 1 || NumberOfPaddles > 5  ) return false;
            return true;

        }
    }
    
}

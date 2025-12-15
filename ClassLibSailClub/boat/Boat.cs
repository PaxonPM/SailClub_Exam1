using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class Boat : IValidate
    {
        
        public string Model { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public int SailNum { get; set; }
        public int Capacity { get; set; }
        public double Length { get; set; }

        public MaintenanceRecord Maintenance { get; } = new MaintenanceRecord();

        public Boat(string model, int year, string name, int sailNum,int capacity, double length)
        {
            
            Model = model;
            Year = year;
            Name = name;
            SailNum = sailNum;
            Capacity = capacity;
            Length = length;
        }

        public override string ToString()
        {
            return $"Model: {Model} \n Year: {Year} \n Name: {Name} \n Sailnumber: {SailNum} \n Capacity: {Capacity} \n Length: {Length}";
        }

        public virtual void Validate()
        {
            if (string.IsNullOrWhiteSpace(Model))
            {
                throw new ArgumentException("Model cannot be null or empty.");
            }
            
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }
            if (SailNum <= 0)
            {
                throw new ArgumentException("Sail number must be a positive integer.");
            }
            if (Capacity <= 0)
            {
                throw new ArgumentException("Capacity must be a positive integer.");
            }
            if (Length <= 0)
            {
                throw new ArgumentException("Length must be a positive number.");
            }
        }

        public virtual bool RoutineValidate()
        {
            if (Year < 1600 || Year > DateTime.Now.Year) return false;
            if (SailNum <= 0) return false;
            if (Capacity <= 0) return false;
            if (Length <= 0) return false;

            return true;
        }

    }
}

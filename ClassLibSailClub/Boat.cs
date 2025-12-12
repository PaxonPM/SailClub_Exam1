using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class Boat
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



    }
}

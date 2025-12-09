using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public static class Initialize
    {
        public static void Start()
        {
            var BoatReg = new BoatReg();
            BoatReg.AddBoat("Speedbåd", "Sunseeker", 1992, "Slice of Life", 001, "Volvo 500 hk", 27.0);
            BoatReg.AddBoat("Sejlbåd", "Maxi", 1978, "Titanic", 002, "Volvo Penta MD7A", 28.0);
            BoatReg.AddBoat("RIB", "Njord Frigg 300", 2023, "Peter", 003, "20 hk", 10.0);
            BoatReg.AddBoat("Motorbåd", "Stingray 270 S", 2008, "Rokken", 004, "Volvo Penta 5.0 GXI", 30.0);
            BoatReg.AddBoat("Sejlbåd", "Oceanis 54", 1980, "Jens", 005, "Volvo 50 hk", 54.0);

            BoatReg.ReadBoat(003);
            BoatReg.DelBoat(002);
            BoatReg.ReadBoat(002);

            var MedlemRegister = new MedlemRegister();
            MedlemRegister.CreateMedlem(003, "Nicolaj", "Nicolajvej 69", "Nicolaj@gmail.com", "78 98 72 63", false);
            MedlemRegister.CreateMedlem(004, "Paw", "Pawgade 420", "Paw@gmail.com", "69 69 69 69", false);
            MedlemRegister.CreateMedlem(005, "Malinda", "Malinda Allé 47", "Malinda@gmail.com", "77 88 99 11 07", false);
            MedlemRegister.CreateMedlem(006, "Lejla", "Lejlastræde 32", "Lejla@gmail.com", " 59 03 77 91", false);
            MedlemRegister.CreateMedlem(007, "Lucas", "Maglegårdsvej 2", "Lucas@gmail.com", "52 30 92 01", true);

        }
    }
}

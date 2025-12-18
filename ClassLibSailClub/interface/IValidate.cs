using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public interface IValidate
    {
        void Validate(); // exception baseret validerring  system fejl, programmet ikke må fortsætte
        bool RoutineValidate(); // bool valdering for routine checks

    }
}

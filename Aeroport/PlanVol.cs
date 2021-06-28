using System;
using System.Collections.Generic;
using System.Text;

namespace aereport
{
    public class PlanVol
    {
        public Aereport AeroportDepart { get; set; }
        public Aereport AerportArrive { get; set; }

        public PlanVol(Aereport depart, Aereport arrive)
        {
            this.AeroportDepart = depart;
            this.AerportArrive = arrive;
        }
    }
}

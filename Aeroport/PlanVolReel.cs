using System;
using System.Collections.Generic;
using System.Text;

namespace aereport
{

    
    public class PlanVolReel : PlanVol 
    {
        public DateTime TempsDepartReel { get; set; }
        public DateTime TempsArrieeReel { get; set; }
        public List<PositionMoment> positionMoment { get; set; }
        public float QtEssenceConsommee { get; set; }

        public PlanVolReel(DateTime tempsdepart, DateTime tempsarrivee, Aereport depart, Aereport arrive): base(depart, arrive) 
     {
            this.TempsDepartReel = tempsdepart;
            this.TempsArrieeReel = tempsarrivee; 
        }

    }
}

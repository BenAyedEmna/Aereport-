using System;
using System.Collections.Generic;
using System.Text;

namespace aereport
{
    public class PlanVolPlanifiee : PlanVol
    {
        public DateTime TempsDepartPlanifiee { set; get; }
        public DateTime TempsArriveePlanifiee { set; get; }
        public double QtEssenceNecessaire { get; set; }
        public List<Suivie> PositionPlanifiee { get; set; }
        public List<Aereport> AeroportAlternative { get; set; }
        public PlanVolPlanifiee(DateTime tempsdepart, DateTime tempsarrivee, Aereport depart, Aereport arrivee) : base(depart, arrivee) 
        {
            this.TempsDepartPlanifiee = tempsdepart;
            this.TempsArriveePlanifiee = tempsarrivee;
        }
    }
}

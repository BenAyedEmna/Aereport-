using System;
using System.Collections.Generic;
using System.Text;

namespace aereport
{
    public class PlanVolPlanifiee : PlanVol
    {
        public DateTime TempsDepartPlanifiee;
        public DateTime TempsArrieePlanifiee;
        public float QtEssenceNecessaire { get; set; }

        public List<Aereport> aeroport_alternative;
        public PlanVolPlanifiee(DateTime tempsdepart, DateTime tempsarrivee, Aereport depart, Aereport arrivee) : base(depart, arrivee) 
        {
            this.TempsDepartPlanifiee = tempsdepart;
            this.TempsArrieePlanifiee = tempsarrivee;
        }
    }
}

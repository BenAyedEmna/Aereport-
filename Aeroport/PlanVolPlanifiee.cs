using System;
using System.Collections.Generic;
using System.Text;

namespace aereport
{
    public class PlanVolPlanifiee : PlanVol
    {
        public DateTime TempsDepartPlanifiee { set; get; }
        public DateTime TempsArrieePlanifiee { set; get; }
        public double QtEssenceNecessaire { get; set; }

        public List<Aereport> aeroport_alternative;
        public PlanVolPlanifiee(DateTime tempsdepart, DateTime tempsarrivee, Aereport depart, Aereport arrivee) : base(depart, arrivee) 
        {
            this.TempsDepartPlanifiee = tempsdepart;
            this.TempsArrieePlanifiee = tempsarrivee;
        }
    }
}

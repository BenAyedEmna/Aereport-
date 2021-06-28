using System;
using System.Collections.Generic;
using System.Text;



namespace aereport
{
    enum Etat
    {
        planifiee,
        encours,
        termine 
    }
    class Vol
    {
        public int Numero; 
        public DateTime ETD; //(estimated time departure)
        public DateTime ETA; //(estimated time arrival)
        public PlanVolPlanifiee PlanPlanifiee { get; set; }
        public PlanVolReel PlanReel { get; set; }
        public Etat Etat { get; set; }
        public EtatPosition EtatPosition { set; get; }
        public Suivie PositionSuivie { get; set; }
        public Vol(int num, DateTime eta ,DateTime pta, PlanVolPlanifiee planifiee, PlanVolReel reel )
        {
            this.Numero = num;
            this.ETA = eta;
            this.PlanPlanifiee = planifiee;
            this.PlanReel=  reel; 
        }
    }
}

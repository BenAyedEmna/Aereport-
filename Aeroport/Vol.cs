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
        public int Numéro_vol; 
        public DateTime ETA; //(estimated time arrival)
        public DateTime PTA; //(Planned time arrival)
        public DateTime ETD; //(estimated time departure)
        public DateTime PTD; //(Planned time departure)
        public PlanVolPlanifiee PlanPlanifiee { get; set; }
        
        public PlanVolReel PlanReel { get; set; }
        public Etat Etat { get; set; }
        public Suivie PositionSuivie { get; set; }
        public 
            Vol(int num, DateTime eta, DateTime pta, DateTime etd, DateTime ptd , PlanVolPlanifiee planifiee , PlanVolReel  reel )
        {
            this.Numéro_vol = num;
            this.ETA = eta;
            this.PTA = pta;
            this.ETD = etd;
            this.PTD = ptd;
            this.PlanPlanifiee= planifiee;
            this.PlanReel= reel; 
        }
    }
}

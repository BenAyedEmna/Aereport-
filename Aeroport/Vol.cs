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

    
    class vol
    {
        private int Numéro_vol;
        private DateTime ETA; //(estimated time arrival)
        private DateTime PTA; //(Planned time arrival)
        private DateTime ETD; //(estimated time departure)
        private DateTime PTD; //(Planned time departure)
        private PlanVolPlanifiee plan_planifiee;
        private PlanVolReel plan_reel;
        private Etat etat; 
        private Position position ;

        public vol(int num , DateTime ETA )
        {
            this.Numéro_vol = num;
            this.ETA = ETA; 
        }
    }
}

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

        public int retard(PlanVolPlanifiee planifiee, PlanVolReel reel) /* retourne 1 en cas de retard , 0 sinon */
        {
            if (DateTime.Compare(reel.TempsArrieeReel, planifiee.TempsArriveePlanifiee) > 0)
                return 1; 
            return 0; 
        }

        public TimeSpan TempsRetard(PlanVolPlanifiee planifiee , PlanVolReel reel )
        {
            TimeSpan r;
            //r= DateTime.Now - DateTime.Now; 
            r=reel.TempsArrieeReel - planifiee.TempsArriveePlanifiee;
            return r; 
        }

        public double VarrianceEssence(PlanVolPlanifiee planifiee, PlanVolReel reel)
        {
            double VarEssence; 
            VarEssence =reel.QtEssenceConsommee -planifiee.QtEssenceNecessaire;
            return VarEssence; 
        }

        public double EcartypeEssence(PlanVolPlanifiee planifiee, PlanVolReel reel)
        {
            double Ecartype;
            Ecartype = Math.Sqrt(Math.Abs(VarrianceEssence(planifiee, reel)));
            return Ecartype; 
        }

        //public List<Suivie> PositionNonRespectees((PlanVolPlanifiee planifiee, PlanVolReel reel) 
        //{
        //    List<Suivie> position = new List<Suivie>();



        //    return position; 
        //}


    }
}

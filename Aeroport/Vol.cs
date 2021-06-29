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

        public bool Retard() 
        {
            if (this.Etat == Etat.termine)
            {
                if (DateTime.Compare(this.PlanReel.TempsArrieeReel, this.PlanPlanifiee.TempsArriveePlanifiee) > 0)
                    return true;
                else
                    return false;
            }
        }

        public TimeSpan TempsRetard()
        {
            TimeSpan r;
            //r= DateTime.Now - DateTime.Now; 
            r=this.PlanReel.TempsArrieeReel - this.PlanPlanifiee.TempsArriveePlanifiee;
            return r; 
        }

        public double VarrianceEssence()
        {
            double VarEssence; 
            VarEssence =this.PlanReel.QtEssenceConsommee -this.PlanPlanifiee.QtEssenceNecessaire;
            return VarEssence; 
        }

        public double EcartypeEssence()
        {
            double Ecartype;
            Ecartype = Math.Sqrt(Math.Abs(VarrianceEssence())); 
            return Ecartype; 
        }

        public List<Suivie> PositionNonRespectees()
        {
            List<Suivie> position = new List<Suivie>();
            foreach(Suivie p in this.PlanPlanifiee.PositionPlanifiee)
            {
                foreach(Suivie r in this.PlanReel.PositionParcouru)
                {
                    if(p.Egale(r)==false)
                    {
                        position.Add(r); 
                    }
                }
            }
            return position;
        }
    }
}

using System;
using System.Collections.Generic;



namespace aereport
{
    class Program
    {
        static void Main(string[] args)
        {

            Aereport aereport1, aereport2, aereport3;
            aereport1 = new Aereport("Aéroport international de Tunis-Carthage");
            aereport2 = new Aereport("Aéroport international de Djerba-Zarzis");
            aereport3 = new Aereport("Aéroport international de Djerba-Zarzis");

            Avion avion1, avion2;
            avion1 = new Avion("Airbus A330", 1992, "Avion d'affaires", 440);
            avion2 = new Avion("Learjet 45", 1992, "Avion d'affaires", 200);

            PlanVolReel planR1, planR2;
            PlanVolPlanifiee planP1, planP2;

            planR1 = new PlanVolReel(new DateTime(2021, 1, 1, 7, 00, 00), new DateTime(2021, 1, 1, 15, 00, 00), aereport1, aereport3);
            planP1 = new PlanVolPlanifiee(new DateTime(2021, 1, 1, 5, 00, 00), new DateTime(2021, 1, 1, 13, 00, 00), aereport1, aereport3);

            planR2 = new PlanVolReel(new DateTime(2021, 1, 2, 9, 00, 00), new DateTime(2021, 1, 2, 9, 30, 00), aereport1, aereport2);
            planP2 = new PlanVolPlanifiee(new DateTime(2021, 1, 2, 8, 30, 00), new DateTime(2021, 1, 1, 9, 00, 00), aereport1, aereport2);

            Vol vol1, vol2;
            vol1 = new Vol(1, new DateTime(2021, 1, 1, 14, 30, 00), new DateTime(2021, 1, 1, 13, 00, 00), planP1, planR1);
            vol2 = new Vol(2, new DateTime(2021, 1, 2, 9, 30, 00), new DateTime(2021, 1, 2, 9, 00, 00), planP2, planR2);


            List<Vol> ListVol = new List<Vol>();
            ListVol.Add(vol1);
            ListVol.Add(vol2);
            int i, c1, c2, qte;
            qte =0;
            double VarEssence, EcartypeEssence;
            TimeSpan retard, MoyRetard;
            retard = DateTime.Now - DateTime.Now;  //initisalisation du retard a 0 

            for (i =0; i < ListVol.Count; i++)
            {
                c1 = DateTime.Compare(ListVol[i].ETA,ListVol[i].PlanReel.TempsArrieeReel);
                c2 = DateTime.Compare(ListVol[i].PlanReel.TempsArrieeReel, DateTime.Now);
                if (c1 < 0 && c2 < 0)
                {
                    qte++;
                    retard = retard + (ListVol[i].PlanReel.TempsArrieeReel - ListVol[i].ETA);
                }
            }
            Console.WriteLine("quantite de retard est {0}", qte);
            MoyRetard = retard / qte;

            foreach (Vol v in ListVol)
            {
                VarEssence = VarEssence + v.PlanReel.QtEssenceConsommee - v.PlanPlanifiee.QtEssenceNecessaire;
            }
            EcartypeEssence = Math.Sqrt(Math.Abs(VarEssence));
            Console.WriteLine("La quantite des vol qui sont terminee et qui sont en retard par rapport a leur date de depart estimee est " + qte);
            Console.WriteLine("La moyenne de leur retard est {0} ", MoyRetard);
            Console.WriteLine("L'ecartype entre la quantite d'essence reelement consomme et celle planfiee est " +EcartypeEssence);
        }
    }
}

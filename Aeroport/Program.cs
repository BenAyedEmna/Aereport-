using System;
using System.Collections.Generic;
using System.Linq; 



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

            Suivie suivieP1, suivieP2, suivieR1, suivieR2, suivieP3, suivieP4, suivieR3, suivieR4; 
            List<Suivie> ListSuivieP1, ListSuivieP2, ListSuivieR1, ListSuivieR2;
            ListSuivieP1 = new List<Suivie>();
            ListSuivieR1 = new List<Suivie>();
            ListSuivieP2 = new List<Suivie>();
            ListSuivieR2 = new List<Suivie>();

            suivieP1 = new Suivie(9.200,44,55,new DateTime(2021,1,1,5,30,00));
            suivieR1 = new Suivie(9.200, 44, 55, new DateTime(2021, 1, 1, 7, 30, 00));
            suivieP2 = new Suivie(11.000,40,55,new DateTime(2021,1,1,7,00,00)); ;
            suivieR2 = new Suivie(9.200, 44, 55, new DateTime(2021,1,1,7,30,00));

            suivieP3 = new Suivie(9.200, 44, 55, new DateTime(2021, 1, 2, 11, 30, 00));
            suivieR3 = new Suivie(9.200, 44, 55, new DateTime(2021, 1, 1, 12, 30, 00));
            suivieP4= new Suivie(11.000, 40, 55, new DateTime(2021, 1, 1, 11, 30, 00)); 
            suivieR4 = new Suivie(9.200, 44, 55, new DateTime(2021, 1, 1, 11, 33, 00));

            ListSuivieP1.Add(suivieP1);
            ListSuivieP1.Add(suivieP2);
            ListSuivieR1.Add(suivieR1);
            ListSuivieR1.Add(suivieR2);

            ListSuivieP2.Add(suivieP1);
            ListSuivieP2.Add(suivieP2);
            ListSuivieR2.Add(suivieR1);
            ListSuivieR2.Add(suivieR2);


            PlanVolReel planR1, planR2;
            PlanVolPlanifiee planP1, planP2;

            planR1 = new PlanVolReel(new DateTime(2021, 1, 1, 7, 00, 00), new DateTime(2021, 1, 1, 15, 00, 00), aereport1, aereport3, ListSuivieR1);
            planP1 = new PlanVolPlanifiee(new DateTime(2021, 1, 1, 5, 00, 00), new DateTime(2021, 1, 1, 13, 00, 00), aereport1, aereport3, ListSuivieP1);

            planR2 = new PlanVolReel(new DateTime(2021, 1, 2, 9, 00, 00), new DateTime(2021, 1, 2, 9, 30, 00), aereport1, aereport2,ListSuivieR2) ;
            planP2 = new PlanVolPlanifiee(new DateTime(2021, 1, 2, 8, 30, 00), new DateTime(2021, 1, 1, 9, 00, 00), aereport1, aereport2,ListSuivieP2);

            Vol vol1, vol2;
            vol1 = new Vol(1, new DateTime(2021, 1, 1, 14, 30, 00), new DateTime(2021, 1, 1, 13, 00, 00), planP1, planR1);
            vol2 = new Vol(2, new DateTime(2021, 1, 2, 9, 30, 00), new DateTime(2021, 1, 2, 9, 00, 00), planP2, planR2);

            int QteRetard = 0;
            TimeSpan Retard;
            double RetardMinutes;
            double EcartypeEssence; 

            List<Vol> ListVol = new List<Vol>();
            ListVol.Add(vol1);
            ListVol.Add(vol2);

            IEnumerable<Vol> VolQuery =
            from vol in ListVol
            where vol.Etat == Etat.termine  
            select vol;

            foreach (Vol Vol in ListVol)
            {
                if (Vol.Retard() == true)
                    QteRetard++;
                Retard = Vol.TempsRetard()+Retard;
                EcartypeEssence = EcartypeEssence + Vol.EcartypeEssence(); 

            }
            RetardMinutes = Retard.TotalMinutes / QteRetard; 
            Console.WriteLine("La quantite des vol qui sont terminee et qui sont en retard par rapport a leur date de depart estimee est {0}", QteRetard );
            Console.WriteLine("La moyenne de leur retard est {0} ", RetardMinutes );
            Console.WriteLine("L'ecartype entre la quantite d'essence reelement consomme et celle planfiee est " +EcartypeEssence);
        
        }
    }
}

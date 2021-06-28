using System;
using System.Collections.Generic;
using System.Text;

namespace aereport
{
    class Avion
    {
        private string Nom;
        private int Annee_de_construction; 
        private string Historique_de_maintenance;
        private string Type_avion; 
        private int Capacite_maximal;
        private Categorie Categorie; 

        public Avion(string nom,int annee)
        {
            this.Nom=nom;
            this.Annee_de_construction = annee; 

        }

    }
}

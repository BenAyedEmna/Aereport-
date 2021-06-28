using System;
using System.Collections.Generic;
using System.Text;

namespace aereport
{
    public class Categorie
    {
        public string Nom { set; get; }
        public string Description { set; get; }
        public Categorie CategorieParent { set; get; }
    }

}

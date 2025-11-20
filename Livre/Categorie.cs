
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Livre
{
    public class Categorie
    {
        public int Id {get; set; }
        public string Nom_Categorie { get; set; }

        public override string? ToString()
        {
            return Nom_Categorie.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Livre
{
    public class Livre
    {
        public Livre()
        {
        }


        public Livre(string titre, string isbn ,int idCategorie, string description)
        {
            Titre = titre;
            Isbn = isbn;
            IdCategorie = idCategorie;
            Description = description;
        }

        public int Id { get; set; }  
        public string Titre { get; set; }

        public string Isbn { get; set; }    
        public int IdCategorie { get; set; }
        public string Description { get; set; }

        public override string? ToString()
        {
            return Titre + "" + Description.ToString();
        }
    }
}
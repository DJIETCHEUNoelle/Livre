using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livre
{
    public class Auteur
    {
        public int Id { get; set; }
        public string Nom {  get; set; }
        public string Prenom { get; set; }

        public override string? ToString()
        {
            return Nom + " "+Prenom.ToString();
        }
    }
}

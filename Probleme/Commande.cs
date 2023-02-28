using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme
{
    /// <summary>
    /// Creation de la class commande et on affiche 
    /// </summary>
    internal class Commande
    {
        public string NumeroCommande { get; set; }
        public string VilleDepart { get; set; }
        public string VilleArriver { get; set; }
        public int Distance { get; set; }

        public string Temps { get; set; }
        public int AncienneterChauffeur { get; set; }
        public int Prix { get; set; }


        public Commande(string numeroCommande, string villeDepart, string villeArriver, int distance, string temps, int ancienneterChauffeur, int prix)
        {
            NumeroCommande = numeroCommande;
            VilleDepart = villeDepart;
            VilleArriver = villeArriver;
            Distance = distance;
            Temps = temps;
            AncienneterChauffeur = ancienneterChauffeur;
            Prix = prix;    
        }

        public override string ToString()
        {
            return "Numéros de commande: " + NumeroCommande + ", Distance la plus court : " + VilleDepart + " -> " + VilleArriver + " distance de : " + Distance + " avec un temps de : " + Temps + " pour un prix de : " + Prix;
        }
    }
}

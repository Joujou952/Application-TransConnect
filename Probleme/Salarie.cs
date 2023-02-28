using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme
{
    /// <summary>
    /// Creationde la class salarié qui hérite de la class personne et on affiche
    /// </summary>
    public class Salarie : Personne
    {
        public DateTime DateEntrer { get; set; }
        public string Poste { get; set; }

        public int Salaire { get; set; }

        public Salarie(string id, string nom, string prenom, DateTime naissance, string adresse, string email, string telephone, DateTime dateEntrer, string poste, int salaire) : base(id, nom, prenom, naissance, adresse, email, telephone) // On appelle le constructeur de la classe Mere 
        {
            DateEntrer = dateEntrer;
            Poste = poste;
            Salaire = salaire;
        }

        public override string ToString()
        {
            return "Id: " + Id + " | " + Nom + " " +Prenom + " " + Poste;
        }
    }
}

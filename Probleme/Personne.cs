using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme
{
    /// <summary>
    /// Creation de la classe personne et on l'affiche
    /// </summary>
    public class Personne
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Naissance { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }


        public Personne(string id, string nom, string prenom, DateTime naissance, string adresse, string email, string telephone)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Naissance = naissance;
            Adresse = adresse;
            Email = email;
            Telephone = telephone;
        }
        public override string ToString()
        {
            return "Coordonnées client : " + "Nom:" + Nom + " Prenom: " + Prenom + " Naissance: " + Naissance + " Adresse: " + Adresse + " Email: " + Email + " Telephone" + Telephone + "\n";
        }
    }      
}

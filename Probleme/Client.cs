using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme
{
    /// <summary>
    /// Creation de la class client qui hérite de la class personne et on affiche 
    /// </summary>
    public class Client : Personne
    {
        public double SommeTotal { get; set; }
        public Client(double sommeTotal, string id, string nom, string prenom, DateTime naissance, string adresse, string email, string telephone) : base(id, nom, prenom, naissance, adresse, email, telephone) // On appelle le constructeur de la classe Mere 
        {
            SommeTotal = sommeTotal;
        }

        public override string ToString()
        {
            return base.ToString() + " Somme totale des achat " + SommeTotal;  //Fait reference au string de la classe mere
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Probleme
{
    /// <summary>
    /// Ici on construire l'arbre pour l'organigramme de l'entreprise, chaque salarier pourra etre ajouter 
    /// dans l'organigrame grace a son n+1 (pere) ou retirer 
    /// </summary>
    public class Organigramme
    {
        
        public Salarie Valeur { get; set; }
        public List<Organigramme> Fils{ get; set; }

        public Organigramme(Salarie valeur)
        {
            Valeur = valeur;
            Fils = new();
        }

        public Organigramme() : this(null) { }

        public void Insertion(Salarie pere, Salarie fils)
        {
            if (Valeur.Equals(pere))
                Fils.Add(new(fils));
            else
                Fils.ForEach(f => f.Insertion(pere, fils));
        }

        public void Retirer(Salarie valeur)
        {
            Organigramme o = Fils.FirstOrDefault(f => f.Valeur.Equals(valeur));
            if (o != null)
            {
                Fils.AddRange(o.Fils);
                Fils.Remove(o);
            }
            else
            {
                Fils.ForEach(f => f.Retirer(valeur));
            }
        }

        public void Affiche(int espace = 0)
        {
            Console.WriteLine("".PadLeft(espace) + "└──" + Valeur.ToString());
            Fils.ForEach(f => f.Affiche(espace + 4));
        }
    }
}

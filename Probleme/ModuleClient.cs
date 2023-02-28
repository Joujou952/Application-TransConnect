using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme
{
    /// <summary>
    /// La classe module client va gerer la liste qui contient les client, 
    /// chaque client sera crée et la liste sera vide au debut, une fonction permettra 
    /// d'ajouter et de retirer des des client de cette liste
    /// </summary>
    internal class ModuleClient
    {
        public static List<Client> ListeDeClient { get; set; } = new List<Client>();

        public ModuleClient()
        {
            ListeDeClient = new List<Client>();
        }
            public void Creation() //Creation du client
        {
            Console.Write("ID du client: ");
            string reponseId = Console.ReadLine();

            Console.Write("Nom du client: ");
            string reponseNom = Console.ReadLine().Trim().ToLower();

            Console.Write("Prénom du client: ");
            string reponsePrenom = Console.ReadLine();

            Console.Write("Date de Naissance du client (Format: JJ/MM/AAAA) : ");
            string reponseNaissance = Console.ReadLine();

            Console.Write("Adresse du client: ");
            string reponseAdresse = Console.ReadLine();

            Console.Write("Email du client: ");
            string reponseEmail = Console.ReadLine();

            Console.Write("Téléphone du client: ");
            string reponseTel = Console.ReadLine();

            Client client = new Client(0, reponseId, reponseNom, reponsePrenom, DateTime.Parse(reponseNaissance), reponseAdresse, reponseEmail, reponseTel); // Creation des clients 
            ListeDeClient.Add(client); //L'ajout du client dans la liste
            Console.WriteLine("Le client a été ajouté! \n" );
        }

        public void Suppression()
        {
            Console.WriteLine("Quel client voulez-vous suprrimer ? (Insérer l'ID du client)");
            string reponseSuppression = Console.ReadLine();
            Client client = ListeDeClient.FirstOrDefault(c => c.Id.Equals(reponseSuppression)); // Renvoie le premier element qui correspond a la condition sinon renvoie null
            ListeDeClient.Remove(client);
            Console.WriteLine("Le client a été Supprimer! \n");
        }

        public void Affichage()
        {
            if (ListeDeClient == null)
            {
                Console.WriteLine("Il n'y a pas de client enregistré");
            }
            else
            {
                Console.WriteLine("Liste des clients triées par ordre alphabétique");
                ListeDeClient.Sort(compareAlphabetique);
                foreach (Client client in ListeDeClient)
                {
                    Console.WriteLine(client);
                }

                Console.WriteLine("Liste des clients triées par ville");
                ListeDeClient.Sort(compareAdresse);
                foreach (Client client in ListeDeClient)
                {
                    Console.WriteLine(client);
                }


                Console.WriteLine("Liste des clients triées par Montant des achats cumulées");
                ListeDeClient.Sort(compareSommeTotal);
                foreach (Client client in ListeDeClient)
                {
                    Console.WriteLine(client);
                }
            }
        }
        public void Modification()
        {
            Console.WriteLine("Indiqué l'ID du client à modifié");
            string reponseModificationClient = Console.ReadLine();
            foreach (Client client in ListeDeClient)//Cherche dans la liste 
            {
                if (client.Id.Equals(reponseModificationClient))//si c'est egale on le supprimme
                {
                    Console.WriteLine("Indiqué quel donnée du client à modifié : \n");
                    Console.WriteLine("Vous pouvez modifier le nom, l'adresse, le mail ou le numéros de téléphone \n");
                    string reponseModification = Console.ReadLine().Trim().ToLower(); // Retirer les espace // retirer toute les majuscules
                    if (reponseModification.Equals("nom"))
                    {
                        Console.Write("Donnez le nouveau nom: ");
                        string nouveauNom = Console.ReadLine();
                        client.Nom = nouveauNom;
                        Console.WriteLine("Le nom à bien été modifié");

                    }
                    else if (reponseModification.Equals("adresse"))
                    {
                        Console.Write("Donnez la nouvelle adresse: ");
                        string nouvelleAdresse = Console.ReadLine();
                        client.Adresse = nouvelleAdresse;
                        Console.WriteLine("Le l'adresse à bien été modifié");


                    }
                    else if (reponseModification.Equals("mail"))
                    {
                        Console.Write("Donnez le nouveau mail: ");
                        string nouveauMail = Console.ReadLine();
                        client.Email = nouveauMail;
                        Console.WriteLine("Le mail à bien été modifié");

                    }
                    else if (reponseModification.Equals("telephone"))
                    {
                        Console.Write("Donnez le nouveau numéro de telephone: ");
                        string nouveauTel = Console.ReadLine();
                        client.Telephone = nouveauTel;
                        Console.WriteLine("Le numéros de téléphone à bien été modifié");
                    }
                }
            }

        }

        private int compareAlphabetique(Client c1, Client c2)
        {
            return c1.Nom.CompareTo(c2.Nom);
        }

        private int compareAdresse(Client c1, Client c2)
        {
            return c1.Adresse.CompareTo(c2.Adresse);
        }

        private int compareSommeTotal(Client c1, Client c2)
        {
            return c1.SommeTotal.CompareTo(c2.SommeTotal);
        }
    }
}

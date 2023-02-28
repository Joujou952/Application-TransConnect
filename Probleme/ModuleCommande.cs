using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Probleme
{
    /// <summary>
    /// La classe module commande va gerer la liste qui contient les commandes, 
    /// il s'agit donc une liste qui sera crée enfonction de la presence ou non 
    /// d'un client dans l'entreprise 
    /// et aussi d'autre fonction permettant de donner le temps de trajet et les kilometre parcours 
    /// en fonction des villes de depart et d'arrivée
    /// Puis un calcul du prix en fonction de la distanc et du chauffeur 
    /// (on estime qu'il sont une experience differente)
    /// </summary>
    internal class ModuleCommande
    {
        public List<Commande> ListeDeCommande { get; set; }

        public ModuleCommande()
        {
            ListeDeCommande = new List<Commande>();
        }

        public void CreationCommande()
        {
            Console.WriteLine("Entré le nom du client pour la commande. ");
            string reponseNomClient = Console.ReadLine().Trim().ToLower();
            Client c = ModuleClient.ListeDeClient.FirstOrDefault(c => c.Nom.Equals(reponseNomClient));  
            if (c == null)
            {
                Console.WriteLine("Le client n'existe pas, il faut le crée");
            }
            else
            {
                Console.Write("Numéros de commande: ");
                string reponseId = Console.ReadLine();

                Console.WriteLine("Selectionner les villes selon la liste suivante:  Paris, Rouen, Lyon, Angers, La Rochelle, Bordeaux, Biarritz, Pau, Toulouse, Montpellier, Nimes, Avignon, Marseille, Toulon, Monaco");
                Console.WriteLine("Donner la ville de depart: ");
                string reponseVilleDepart = Console.ReadLine().Trim().ToLower();

                Console.Write("Donner la ville d'arrivée: ");
                string reponseVilleArriver = Console.ReadLine().Trim().ToLower();

                int reponseDistance = 0;
                string reponseTemps = "X";

                do
                {
                    switch (reponseVilleDepart)
                    {
                        case "paris":
                            switch (reponseVilleArriver)
                            {
                                case "rouen":
                                    reponseDistance = 133; reponseTemps = "1h45"; break;
                                case "lyon":
                                    reponseDistance = 464; reponseTemps = "4h55"; break;
                                case "angers":
                                    reponseDistance = 294; reponseTemps = "1h11"; break;
                                default:
                                    Console.Write("La ville d'arrivé n'est pas répertorié "); break;
                            }
                            break;
                        case "rouen":
                            switch (reponseVilleArriver)
                            {
                                case "paris":
                                    reponseDistance = 133; reponseTemps = "1h45"; break;
                                default:
                                    Console.Write("La ville d'arrivé n'est pas répertorié "); break;
                            }
                            break;
                        case "lyon":
                            switch (reponseVilleArriver)
                            {
                                case "paris":
                                    reponseDistance = 464; reponseTemps = "4h55"; break;
                                default:
                                    Console.Write("La ville d'arrivé n'est pas répertorié "); break;
                            }
                            break;
                        case "angers":
                            switch (reponseVilleArriver)
                            {
                                case "larochelle":
                                    reponseDistance = 187; reponseTemps = "2h20"; break;
                                case "paris":
                                    reponseDistance = 294; reponseTemps = "3h11"; break;
                                default:
                                    Console.Write("La ville d'arrivé n'est pas répertorié "); break;
                            }
                            break;
                        case "larochelle":
                            switch (reponseVilleArriver)
                            {
                                case "bordeaux":
                                    reponseDistance = 183; reponseTemps = "1h38"; break;
                                case "angers":
                                    reponseDistance = 187; reponseTemps = "2h20"; break;
                                default:
                                    Console.Write("La ville d'arrivé n'est pas répertorié "); break;
                            }
                            break;
                        case "bordeaux":
                            switch (reponseVilleArriver)
                            {
                                case "larochelle":
                                    reponseDistance = 183; reponseTemps = "1h38"; break;
                                case "biarritz":
                                    reponseDistance = 202; reponseTemps = "1h47"; break;
                                default:
                                    Console.Write("La ville d'arrivé n'est pas répertorié "); break;
                            }
                            break;
                        case "biarritz":
                            switch (reponseVilleArriver)
                            {
                                case "bordeaux":
                                    reponseDistance = 202; reponseTemps = "1h47"; break;
                                case "toulouse":
                                    reponseDistance = 309; reponseTemps = "2h39"; break;
                                default:
                                    Console.Write("La ville d'arrivé n'est pas répertorié "); break;
                            }
                            break;
                        case "toulouse":
                            switch (reponseVilleArriver)
                            {
                                case "biarritz":
                                    reponseDistance = 309; reponseTemps = "2h39"; break;
                                case "pau":
                                    reponseDistance = 193; reponseTemps = "1h41"; break;
                                case "nimes":
                                    reponseDistance = 289; reponseTemps = "2h26"; break;
                                default:
                                    Console.Write("La ville d'arrivé n'est pas répertorié "); break;
                            }
                            break;
                        case "montpellier":
                            switch (reponseVilleArriver)
                            {
                                case "nimes":
                                    reponseDistance = 52; reponseTemps = "35min"; break;
                                default:
                                    Console.Write("La ville d'arrivé n'est pas répertorié "); break;
                            }
                            break;
                        case "nimes":
                            switch (reponseVilleArriver)
                            {
                                case "toulouse":
                                    reponseDistance = 289; reponseTemps = "2h26"; break;
                                case "montpellier":
                                    reponseDistance = 52; reponseTemps = "35min"; break;
                                case "marseille":
                                    reponseDistance = 126; reponseTemps = "1h13"; break;
                                default:
                                    Console.Write("La ville d'arrivé n'est pas répertorié "); break;
                            }
                            break;
                        case "marseille":
                            switch (reponseVilleArriver)
                            {
                                case "nimes":
                                    reponseDistance = 126; reponseTemps = "1h13"; break;
                                case "avignon":
                                    reponseDistance = 99; reponseTemps = "1h"; break;
                                case "monaco":
                                    reponseDistance = 224; reponseTemps = "2h3"; break;
                                default:
                                    Console.Write("La ville d'arrivé n'est pas répertorié "); break;
                            }
                            break;
                        case "monaco":
                            switch (reponseVilleArriver)
                            {
                                case "toulon":
                                    reponseDistance = 169; reponseTemps = "1h35"; break;
                                case "marseille":
                                    reponseDistance = 224; reponseTemps = "2h3"; break;
                                default:
                                    Console.Write("La ville d'arrivé n'est pas répertorié "); break;
                            }
                            break;
                        case "toulon":
                            switch (reponseVilleArriver)
                            {
                                case "monaco":
                                    reponseDistance = 169; reponseTemps = "1h35"; break;
                                default:
                                    Console.Write("La ville d'arrivé n'est pas répertorié "); break;
                            }
                            break;

                        default:
                            Console.Write("La ville de depart n'est pas répertorié ");
                            break;
                    }
                    if (reponseDistance == 0)
                    {
                        Console.Write("Donner une ville de depart valide: ");
                        reponseVilleDepart = Console.ReadLine().Trim().ToLower();

                        Console.Write("Donner une ville d'arrivée valide: ");
                        reponseVilleArriver = Console.ReadLine().Trim().ToLower();
                    }
                } while (reponseDistance == 0);

                int ancienneterChauffeur = 0;

                Console.WriteLine("Entré l'ID du Chauffeur pour la commande. (00010 à 00014)");
                string reponseIdChauffeur = Console.ReadLine();
                    switch (reponseIdChauffeur)
                    {
                        case "00010":
                            ancienneterChauffeur = 2; break;
                        case "00011":
                            ancienneterChauffeur = 1; break;
                        case "00012":
                            ancienneterChauffeur = 3; break;
                        case "00013":
                            ancienneterChauffeur = 4; break;
                        case "00014":
                            ancienneterChauffeur = 5; break;
                    }
                

                int reponsePrix = reponseDistance * ancienneterChauffeur;

                Commande commande = new Commande(reponseId, reponseVilleDepart, reponseVilleArriver, reponseDistance, reponseTemps, ancienneterChauffeur, reponsePrix);
                ListeDeCommande.Add(commande);
                Console.WriteLine("La commande a été ajouté à la base de donnée! \n");
            }
        }
        public void AffichageCommande() 
        {
            if (ListeDeCommande != null)
            {
                Console.WriteLine("Voici les commandes enregistrer");
                foreach (Commande commande in ListeDeCommande)
                {
                    Console.WriteLine(commande);
                }
            }
            else
            {
                Console.WriteLine("Il n'y a pas de commande enregistré");

            }
        }
    }
}
   

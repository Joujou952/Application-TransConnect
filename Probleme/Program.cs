namespace Probleme
{
    internal class Program
    {

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("------Application TransConnect------");
            Console.WriteLine(" 1 - Module Client ");
            Console.WriteLine(" 2 - Module Salarié");
            Console.WriteLine(" 3 - Module Commande");
            Console.WriteLine(" 4 - Module Statistique");
            Console.WriteLine(" Q - Quitter");
            Console.WriteLine("Quel module voulez-vous tester : ");
        }

        static void sousMenuClient()
        {
            Console.WriteLine("------Menu Module Client------");
            Console.WriteLine(" 1 - Crée un client ");
            Console.WriteLine(" 2 - Afficher la liste des clients par ordre");
            Console.WriteLine(" 3 - Modifier la fiche d'un client");
            Console.WriteLine(" 4 - Supprimer la fiche d'un client");
            Console.WriteLine(" P - Précédent");
            Console.WriteLine("Que voulez-vous faire : ");
        }

        static void menuModuleClient()
        {
            string choixUtilisateur;
            ModuleClient MC = new ModuleClient();
            do
            {
                sousMenuClient();
                choixUtilisateur = Console.ReadLine().Trim().ToLower();
                switch (choixUtilisateur)
                {
                    case "1":
                        MC.Creation();
                        break;
                    case "2":
                        MC.Affichage();
                        break;
                    case "3":
                        MC.Modification();
                        break;
                    case "4":
                        MC.Suppression();
                        break;
                }

            } while (choixUtilisateur != "p");
        }

        static void sousMenuSalarie()
        {
            Console.WriteLine("------Menu Module Salarie------");
            Console.WriteLine(" 1 - Embauché un salarié ");
            Console.WriteLine(" 2 - Licencié un salarié");
            Console.WriteLine(" 3 - Afficher l'organigramme de l'entreprise");
            Console.WriteLine(" P - Précédent");
            Console.WriteLine("Que voulez-vous faire : ");
        }

        static void menuModuleSalarie()
        {
            string choixUtilisateur;
            ModuleSalarie MS = new ModuleSalarie();
            MS.ListeSalarie();
            do
            {
                sousMenuSalarie();
                choixUtilisateur = Console.ReadLine().Trim().ToLower();
                switch (choixUtilisateur)
                {
                    case "1":
                        MS.Embauchement();
                        break;
                    case "2":
                        MS.Licenciment();
                        break;
                    case "3":
                        MS.Affichage();
                        break;
                }

            } while (choixUtilisateur != "p");
        }

        static void sousMenuCommande()
        {
            Console.WriteLine("------Menu Module Commande------");
            Console.WriteLine(" 1 - Crée une commande ");
            Console.WriteLine(" 2 - Afficher les commandes");
            Console.WriteLine(" P - Précédent");
            Console.WriteLine("Que voulez-vous faire : ");
        }

        static void menuModuleCommande()
        {
            string choixUtilisateur;
            ModuleCommande MCO = new ModuleCommande();
            do
            {
                sousMenuCommande();
                choixUtilisateur = Console.ReadLine().Trim().ToLower();
                switch (choixUtilisateur)
                {
                    case "1":
                        MCO.CreationCommande();
                        break;
                    case "2":
                        MCO.AffichageCommande();
                        break;
                }
            } while (choixUtilisateur != "p");
        }


        static void Main(string[] args)
        {
            string choixUtilisateur;
            do
            {
                menu();
                choixUtilisateur = Console.ReadLine().Trim().ToLower();
                switch (choixUtilisateur)
                {
                    case "1":
                        menuModuleClient();
                        break;
                    case "2":
                        menuModuleSalarie(); 
                        break;
                    case "3":
                        menuModuleCommande(); 
                        break;
                    case "4":
                        //MC.Suppression();
                        break;
                }

            } while (choixUtilisateur != "q");
        }
    }
}
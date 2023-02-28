using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme
{
    /// <summary>
    /// La classe module salarie va gerer la liste qui contient les salarié, 
    /// il s'agit donc une liste crée a la main et aussi d'autre fonction permettant 
    /// d'ajouter et de retirer des salarié de cette liste
    /// L'affichage se fera via un organigramme en utilisant un arbre n-aire
    /// </summary>
    internal class ModuleSalarie
    {
        public static List<Salarie> ListeDeSalarie { get; set; } = new List<Salarie>();
        public Organigramme Organigramme { get; set; }

        public ModuleSalarie()
        {
            ListeDeSalarie = new List<Salarie>();
            Organigramme = new();
        }

        public void ListeSalarie()
        {
            string salarie1Id = "0001";
            string salarie1Nom = "Dupond";
            string salarie1Prenom = "Jean";
            var salarie1NaissanceString = "05/01/2008";
            DateTime salarie1Naissance = DateTime.ParseExact(salarie1NaissanceString, "dd/MM/yyyy", null);
            string salarie1Adresse = "avenue jean";
            string salarie1Mail = "adresse@hotmail.com";
            string salarie1Tel = "06.19.XX.XX.XX";
            var salarie1EntrerString = "29/10/2001";
            DateTime salarie1Entrer = DateTime.ParseExact(salarie1EntrerString, "dd/MM/yyyy", null);
            string salarie1Poste = "Directeur Générale";
            int salarie1Salaire = 5500;

            Salarie salarie1 = new Salarie(salarie1Id, salarie1Nom, salarie1Prenom, salarie1Naissance, salarie1Adresse, salarie1Mail, salarie1Tel, salarie1Entrer, salarie1Poste, salarie1Salaire); // Creation des salarié 
            ListeDeSalarie.Add(salarie1); //L'ajout du Salarié dans la liste
            Organigramme.Valeur = salarie1;

            string salarie2Id = "0002";
            string salarie2Nom = "Fiesta";
            string salarie2Prenom = "Marie";
            var salarie2NaissanceString = "19/10/1990";
            DateTime salarie2Naissance = DateTime.ParseExact(salarie2NaissanceString, "dd/MM/yyyy", null);
            string salarie2Adresse = "avenue jean";
            string salarie2Mail = "adresse@hotmail.com";
            string salarie2Tel = "06.29.XX.XX.XX";
            var salarie2EntrerString = "29/10/1998";
            DateTime salarie2Entrer = DateTime.ParseExact(salarie2EntrerString, "dd/MM/yyyy", null);
            string salarie2Poste = "Directrice Commerciale";
            int salarie2Salaire = 4000;

            Salarie salarie2 = new Salarie(salarie2Id, salarie2Nom, salarie2Prenom, salarie2Naissance, salarie2Adresse, salarie2Mail, salarie2Tel, salarie2Entrer, salarie2Poste, salarie2Salaire); 
            ListeDeSalarie.Add(salarie2);
            Organigramme.Insertion(salarie1, salarie2);

            string salarie3Id = "0003";
            string salarie3Nom = "Fetard";
            string salarie3Prenom = "Marc";
            var salarie3NaissanceString = "09/01/1985";
            DateTime salarie3Naissance = DateTime.ParseExact(salarie3NaissanceString, "dd/MM/yyyy", null);
            string salarie3Adresse = "avenue jean";
            string salarie3Mail = "adresse@hotmail.com";
            string salarie3Tel = "06.32.XX.XX.XX";
            var salarie3EntrerString = "12/07/1990";
            DateTime salarie3Entrer = DateTime.ParseExact(salarie3EntrerString, "dd/MM/yyyy", null);
            string salarie3Poste = "Directeur des opérations";
            int salarie3Salaire = 4000;

            Salarie salarie3 = new Salarie(salarie3Id, salarie3Nom, salarie3Prenom, salarie3Naissance, salarie3Adresse, salarie3Mail, salarie3Tel, salarie3Entrer, salarie3Poste, salarie3Salaire);
            ListeDeSalarie.Add(salarie3);
            Organigramme.Insertion(salarie1, salarie3);


            string salarie4Id = "0004";
            string salarie4Nom = "Joyeuse";
            string salarie4Prenom = "Jeanne";
            var salarie4NaissanceString = "09/01/1985";
            DateTime salarie4Naissance = DateTime.ParseExact(salarie4NaissanceString, "dd/MM/yyyy", null);
            string salarie4Adresse = "avenue jean";
            string salarie4Mail = "adresse@hotmail.com";
            string salarie4Tel = "06.32.XX.XX.XX";
            var salarie4EntrerString = "12/07/1990";
            DateTime salarie4Entrer = DateTime.ParseExact(salarie4EntrerString, "dd/MM/yyyy", null);
            string salarie4Poste = "Directrice RH";
            int salarie4Salaire = 3400;

            Salarie salarie4 = new Salarie(salarie4Id, salarie4Nom, salarie4Prenom, salarie4Naissance, salarie4Adresse, salarie4Mail, salarie4Tel, salarie4Entrer, salarie4Poste, salarie4Salaire);
            ListeDeSalarie.Add(salarie4);
            Organigramme.Insertion(salarie1, salarie4);

            string salarie5Id = "0005";
            string salarie5Nom = "Gripsou";
            string salarie5Prenom = "Amine";
            var salarie5NaissanceString = "25/05/2005";
            DateTime salarie5Naissance = DateTime.ParseExact(salarie5NaissanceString, "dd/MM/yyyy", null);
            string salarie5Adresse = "avenue jean";
            string salarie5Mail = "adresse@hotmail.com";
            string salarie5Tel = "06.64.XX.XX.XX";
            var salarie5EntrerString = "12/07/1990";
            DateTime salarie5Entrer = DateTime.ParseExact(salarie5EntrerString, "dd/MM/yyyy", null);
            string salarie5Poste = "Directeur Financier";
            int salarie5Salaire = 3200;

            Salarie salarie5 = new Salarie(salarie5Id, salarie5Nom, salarie5Prenom, salarie5Naissance, salarie5Adresse, salarie5Mail, salarie5Tel, salarie5Entrer, salarie5Poste, salarie5Salaire);
            ListeDeSalarie.Add(salarie5);
            Organigramme.Insertion(salarie1, salarie5);

            string salarie6Id = "0006";
            string salarie6Nom = "Forge";
            string salarie6Prenom = "George";
            var salarie6NaissanceString = "09/01/1965";
            DateTime salarie6Naissance = DateTime.ParseExact(salarie6NaissanceString, "dd/MM/yyyy", null);
            string salarie6Adresse = "avenue jean";
            string salarie6Mail = "adresse@hotmail.com";
            string salarie6Tel = "06.56.XX.XX.XX";
            var salarie6EntrerString = "16/09/1995";
            DateTime salarie6Entrer = DateTime.ParseExact(salarie6EntrerString, "dd/MM/yyyy", null);
            string salarie6Poste = "Commercial";
            int salarie6Salaire = 2579;

            Salarie salarie6 = new Salarie(salarie6Id, salarie6Nom, salarie6Prenom, salarie6Naissance, salarie6Adresse, salarie6Mail, salarie6Tel, salarie6Entrer, salarie6Poste, salarie6Salaire);
            ListeDeSalarie.Add(salarie6);
            Organigramme.Insertion(salarie2, salarie6);


            string salarie7Id = "0007";
            string salarie7Nom = "Fermi";
            string salarie7Prenom = "François";
            var salarie7NaissanceString = "19/09/1975";
            DateTime salarie7Naissance = DateTime.ParseExact(salarie7NaissanceString, "dd/MM/yyyy", null);
            string salarie7Adresse = "avenue jean";
            string salarie7Mail = "adresse@hotmail.com";
            string salarie7Tel = "06.89.XX.XX.XX";
            var salarie7EntrerString = "24/12/2005";
            DateTime salarie7Entrer = DateTime.ParseExact(salarie7EntrerString, "dd/MM/yyyy", null);
            string salarie7Poste = "Commerciale";
            int salarie7Salaire = 2600;

            Salarie salarie7 = new Salarie(salarie7Id, salarie7Nom, salarie7Prenom, salarie7Naissance, salarie7Adresse, salarie7Mail, salarie7Tel, salarie7Entrer, salarie7Poste, salarie7Salaire);
            ListeDeSalarie.Add(salarie7);
            Organigramme.Insertion(salarie2, salarie7);

            string salarie8Id = "0008";
            string salarie8Nom = "Royal";
            string salarie8Prenom = "Yane";
            var salarie8NaissanceString = "03/12/1999";
            DateTime salarie8Naissance = DateTime.ParseExact(salarie8NaissanceString, "dd/MM/yyyy", null);
            string salarie8Adresse = "avenue jean";
            string salarie8Mail = "adresse@hotmail.com";
            string salarie8Tel = "06.99.34.XX.XX";
            var salarie8EntrerString = "26/11/2020";
            DateTime salarie8Entrer = DateTime.ParseExact(salarie8EntrerString, "dd/MM/yyyy", null);
            string salarie8Poste = "Chef d'équipe";
            int salarie8Salaire = 3579;

            Salarie salarie8 = new Salarie(salarie8Id, salarie8Nom, salarie8Prenom, salarie8Naissance, salarie8Adresse, salarie8Mail, salarie8Tel, salarie8Entrer, salarie8Poste, salarie8Salaire);
            ListeDeSalarie.Add(salarie8);
            Organigramme.Insertion(salarie3, salarie8);

            string salarie9Id = "0009";
            string salarie9Nom = "Prince";
            string salarie9Prenom = "Sarah";
            var salarie9NaissanceString = "09/01/1970";
            DateTime salarie9Naissance = DateTime.ParseExact(salarie9NaissanceString, "dd/MM/yyyy", null);
            string salarie9Adresse = "avenue jean";
            string salarie9Mail = "adresse@hotmail.com";
            string salarie9Tel = "06.45.67.XX.XX";
            var salarie9EntrerString = "06/12/2014";
            DateTime salarie9Entrer = DateTime.ParseExact(salarie9EntrerString, "dd/MM/yyyy", null);
            string salarie9Poste = "Chef d'équipe";
            int salarie9Salaire = 3800;

            Salarie salarie9 = new Salarie(salarie9Id, salarie9Nom, salarie9Prenom, salarie9Naissance, salarie9Adresse, salarie9Mail, salarie9Tel, salarie9Entrer, salarie9Poste, salarie9Salaire);
            ListeDeSalarie.Add(salarie9);
            Organigramme.Insertion(salarie3, salarie9);

            string salarie10Id = "00010";
            string salarie10Nom = "Romu";
            string salarie10Prenom = "Batiste";
            var salarie10NaissanceString = "09/01/1959";
            DateTime salarie10Naissance = DateTime.ParseExact(salarie10NaissanceString, "dd/MM/yyyy", null);
            string salarie10Adresse = "avenue jean";
            string salarie10Mail = "adresse@hotmail.com";
            string salarie10Tel = "06.87.34.XX.XX";
            var salarie10EntrerString = "06/12/2014";
            DateTime salarie10Entrer = DateTime.ParseExact(salarie10EntrerString, "dd/MM/yyyy", null);
            string salarie10Poste = "Chauffeur";
            int salarie10Salaire = 1800;

            Salarie salarie10 = new Salarie(salarie10Id, salarie10Nom, salarie10Prenom, salarie10Naissance, salarie10Adresse, salarie10Mail, salarie10Tel, salarie10Entrer, salarie10Poste, salarie10Salaire);
            ListeDeSalarie.Add(salarie10);
            Organigramme.Insertion(salarie8, salarie10);

            string salarie11Id = "00011";
            string salarie11Nom = "Romi";
            string salarie11Prenom = "Marc";
            var salarie11NaissanceString = "05/01/2008";
            DateTime salarie11Naissance = DateTime.ParseExact(salarie11NaissanceString, "dd/MM/yyyy", null);
            string salarie11Adresse = "avenue jean";
            string salarie11Mail = "adresse@hotmail.com";
            string salarie11Tel = "06.19.45.20.XX";
            var salarie11EntrerString = "29/10/2001";
            DateTime salarie11Entrer = DateTime.ParseExact(salarie11EntrerString, "dd/MM/yyyy", null);
            string salarie11Poste = "Chauffeur";
            int salarie11Salaire = 5500;

            Salarie salarie11 = new Salarie(salarie11Id, salarie11Nom, salarie11Prenom, salarie11Naissance, salarie11Adresse, salarie11Mail, salarie11Tel, salarie11Entrer, salarie11Poste, salarie11Salaire);  
            ListeDeSalarie.Add(salarie11);
            Organigramme.Insertion(salarie8, salarie11);


            string salarie12Id = "00012";
            string salarie12Nom = "Roma";
            string salarie12Prenom = "Marie";
            var salarie12NaissanceString = "19/10/1990";
            DateTime salarie12Naissance = DateTime.ParseExact(salarie12NaissanceString, "dd/MM/yyyy", null);
            string salarie12Adresse = "avenue jean";
            string salarie12Mail = "adresse@hotmail.com";
            string salarie12Tel = "06.49.67.88.XX";
            var salarie12EntrerString = "29/10/1998";
            DateTime salarie12Entrer = DateTime.ParseExact(salarie12EntrerString, "dd/MM/yyyy", null);
            string salarie12Poste = "Chauffeur";
            int salarie12Salaire = 1600;

            Salarie salarie12 = new Salarie(salarie12Id, salarie12Nom, salarie12Prenom, salarie12Naissance, salarie12Adresse, salarie12Mail, salarie12Tel, salarie12Entrer, salarie12Poste, salarie12Salaire);
            ListeDeSalarie.Add(salarie12);
            Organigramme.Insertion(salarie8, salarie12);

            string salarie13Id = "00013";
            string salarie13Nom = "Rome";
            string salarie13Prenom = "Yvonne";
            var salarie13NaissanceString = "09/01/1985";
            DateTime salarie13Naissance = DateTime.ParseExact(salarie13NaissanceString, "dd/MM/yyyy", null);
            string salarie13Adresse = "avenue jean";
            string salarie13Mail = "adresse@hotmail.com";
            string salarie13Tel = "06.23.34.56.XX";
            var salarie13EntrerString = "12/07/1990";
            DateTime salarie13Entrer = DateTime.ParseExact(salarie13EntrerString, "dd/MM/yyyy", null);
            string salarie13Poste = "Chauffeur";
            int salarie13Salaire = 1670;

            Salarie salarie13 = new Salarie(salarie13Id, salarie13Nom, salarie13Prenom, salarie13Naissance, salarie13Adresse, salarie13Mail, salarie13Tel, salarie13Entrer, salarie13Poste, salarie13Salaire);
            ListeDeSalarie.Add(salarie13);
            Organigramme.Insertion(salarie9, salarie13);


            string salarie14Id = "00014";
            string salarie14Nom = "Rimou";
            string salarie14Prenom = "Jeanne";
            var salarie14NaissanceString = "09/01/1985";
            DateTime salarie14Naissance = DateTime.ParseExact(salarie14NaissanceString, "dd/MM/yyyy", null);
            string salarie14Adresse = "avenue jean";
            string salarie14Mail = "adresse@hotmail.com";
            string salarie14Tel = "06.32.XX.XX.XX";
            var salarie14EntrerString = "12/07/1985";
            DateTime salarie14Entrer = DateTime.ParseExact(salarie14EntrerString, "dd/MM/yyyy", null);
            string salarie14Poste = "Chauffeur";
            int salarie14Salaire = 2200;

            Salarie salarie14 = new Salarie(salarie14Id, salarie14Nom, salarie14Prenom, salarie14Naissance, salarie14Adresse, salarie14Mail, salarie14Tel, salarie14Entrer, salarie14Poste, salarie14Salaire);
            ListeDeSalarie.Add(salarie14);
            Organigramme.Insertion(salarie9, salarie14);

            string salarie15Id = "00015";
            string salarie15Nom = "Couleur";
            string salarie15Prenom = "Anne";
            var salarie15NaissanceString = "25/05/2005";
            DateTime salarie15Naissance = DateTime.ParseExact(salarie15NaissanceString, "dd/MM/yyyy", null);
            string salarie15Adresse = "avenue jean";
            string salarie15Mail = "adresse@hotmail.com";
            string salarie15Tel = "06.64.21.23.XX";
            var salarie15EntrerString = "12/07/1990";
            DateTime salarie15Entrer = DateTime.ParseExact(salarie15EntrerString, "dd/MM/yyyy", null);
            string salarie15Poste = "Formation";
            int salarie15Salaire = 3200;

            Salarie salarie15 = new Salarie(salarie15Id, salarie15Nom, salarie15Prenom, salarie15Naissance, salarie15Adresse, salarie15Mail, salarie15Tel, salarie15Entrer, salarie15Poste, salarie15Salaire);
            ListeDeSalarie.Add(salarie15);
            Organigramme.Insertion(salarie4, salarie15);

            string salarie16Id = "00016";
            string salarie16Nom = "Toutlemonde";
            string salarie16Prenom = "Anna";
            var salarie16NaissanceString = "09/01/1965";
            DateTime salarie16Naissance = DateTime.ParseExact(salarie16NaissanceString, "dd/MM/yyyy", null);
            string salarie16Adresse = "avenue jean";
            string salarie16Mail = "adresse@hotmail.com";
            string salarie16Tel = "06.56.XX.XX.XX";
            var salarie16EntrerString = "16/09/1995";
            DateTime salarie16Entrer = DateTime.ParseExact(salarie16EntrerString, "dd/MM/yyyy", null);
            string salarie16Poste = "Contrats";
            int salarie16Salaire = 2579;

            Salarie salarie16 = new Salarie(salarie16Id, salarie16Nom, salarie16Prenom, salarie16Naissance, salarie16Adresse, salarie16Mail, salarie16Tel, salarie16Entrer, salarie16Poste, salarie16Salaire);
            ListeDeSalarie.Add(salarie16);
            Organigramme.Insertion(salarie4, salarie16);

            string salarie17Id = "00017";
            string salarie17Nom = "Picsou";
            string salarie17Prenom = "Jack";
            var salarie17NaissanceString = "19/09/1975";
            DateTime salarie17Naissance = DateTime.ParseExact(salarie17NaissanceString, "dd/MM/yyyy", null);
            string salarie17Adresse = "avenue jean";
            string salarie17Mail = "adresse@hotmail.com";
            string salarie17Tel = "06.89.26.39.XX";
            var salarie17EntrerString = "24/12/2005";
            DateTime salarie17Entrer = DateTime.ParseExact(salarie17EntrerString, "dd/MM/yyyy", null);
            string salarie17Poste = "Commerciale";
            int salarie17Salaire = 2647;

            Salarie salarie17 = new Salarie(salarie17Id, salarie17Nom, salarie17Prenom, salarie17Naissance, salarie17Adresse, salarie17Mail, salarie17Tel, salarie17Entrer, salarie17Poste, salarie17Salaire);
            ListeDeSalarie.Add(salarie17);
            Organigramme.Insertion(salarie5, salarie17);

            string salarie18Id = "00018";
            string salarie18Nom = "Fournier";
            string salarie18Prenom = "Yane";
            var salarie18NaissanceString = "03/12/1999";
            DateTime salarie18Naissance = DateTime.ParseExact(salarie18NaissanceString, "dd/MM/yyyy", null);
            string salarie18Adresse = "avenue jean";
            string salarie18Mail = "adresse@hotmail.com";
            string salarie18Tel = "06.19.34.45.XX";
            var salarie18EntrerString = "26/11/2020";
            DateTime salarie18Entrer = DateTime.ParseExact(salarie18EntrerString, "dd/MM/yyyy", null);
            string salarie18Poste = "Comptable";
            int salarie18Salaire = 1979;

            Salarie salarie18 = new Salarie(salarie18Id, salarie18Nom, salarie18Prenom, salarie18Naissance, salarie18Adresse, salarie18Mail, salarie18Tel, salarie18Entrer, salarie18Poste, salarie18Salaire);
            ListeDeSalarie.Add(salarie18);
            Organigramme.Insertion(salarie17, salarie18);

            string salarie19Id = "00019";
            string salarie19Nom = "Gautier";
            string salarie19Prenom = "Sofiane";
            var salarie19NaissanceString = "09/01/1970";
            DateTime salarie19Naissance = DateTime.ParseExact(salarie19NaissanceString, "dd/MM/yyyy", null);
            string salarie19Adresse = "avenue jean";
            string salarie19Mail = "adresse@hotmail.com";
            string salarie19Tel = "06.45.47.76.XX";
            var salarie19EntrerString = "06/12/2014";
            DateTime salarie19Entrer = DateTime.ParseExact(salarie19EntrerString, "dd/MM/yyyy", null);
            string salarie19Poste = "Comptable";
            int salarie19Salaire = 2349;

            Salarie salarie19 = new Salarie(salarie19Id, salarie19Nom, salarie19Prenom, salarie19Naissance, salarie19Adresse, salarie19Mail, salarie19Tel, salarie19Entrer, salarie19Poste, salarie19Salaire);
            ListeDeSalarie.Add(salarie19);
            Organigramme.Insertion(salarie17, salarie19);

            string salarie20Id = "00020";
            string salarie20Nom = "GrosSous";
            string salarie20Prenom = "Bastien";
            var salarie20NaissanceString = "09/01/1959";
            DateTime salarie20Naissance = DateTime.ParseExact(salarie20NaissanceString, "dd/MM/yyyy", null);
            string salarie20Adresse = "avenue jean";
            string salarie20Mail = "adresse@hotmail.com";
            string salarie20Tel = "06.37.34.46.XX";
            var salarie20EntrerString = "06/12/2014";
            DateTime salarie20Entrer = DateTime.ParseExact(salarie20EntrerString, "dd/MM/yyyy", null);
            string salarie20Poste = "Controleur de gestion";
            int salarie20Salaire = 1800;

            Salarie salarie20 = new Salarie(salarie20Id, salarie20Nom, salarie20Prenom, salarie20Naissance, salarie20Adresse, salarie20Mail, salarie20Tel, salarie20Entrer, salarie20Poste, salarie20Salaire);
            ListeDeSalarie.Add(salarie20);
            Organigramme.Insertion(salarie5, salarie20);
        }

        public void Affichage()
        {
            Organigramme.Affiche();
        }

        public void Embauchement() //Creation du salarié
        {
            Console.Write("ID du salarié: ");
            string reponseId = Console.ReadLine();

            Console.Write("Nom du salarié: ");
            string reponseNom = Console.ReadLine();

            Console.Write("Prénom du salarié: ");
            string reponsePrenom = Console.ReadLine();

            Console.Write("Date de Naissance du salarié (Format: JJ/MM/AAAA) : ");
            string reponseNaissance = Console.ReadLine();

            Console.Write("Adresse du salarié: ");
            string reponseAdresse = Console.ReadLine();

            Console.Write("Email du salarié: ");
            string reponseEmail = Console.ReadLine();

            Console.Write("Téléphone du salarié: ");
            string reponseTel = Console.ReadLine();

            Console.Write("Date d'entrée du salarié (Format: JJ/MM/AAAA) : ");
            string reponseEntrer = Console.ReadLine();

            Console.Write("Poste du salarié: ");
            string reponsePoste = Console.ReadLine();

            Console.Write("Salaire du salarié: ");
            int reponseSalaire = int.Parse(Console.ReadLine());

            Salarie salarie = new Salarie(reponseId, reponseNom, reponsePrenom, DateTime.Parse(reponseNaissance), reponseAdresse, reponseEmail, reponseTel, DateTime.Parse(reponseEntrer), reponsePoste, reponseSalaire); // Creation des salarié 
            ListeDeSalarie.Add(salarie); //L'ajout du Salarié dans la liste

            Console.Write("Donnez l'id du n+1: ");
            string reponseID = Console.ReadLine();
            Salarie n1 = ListeDeSalarie.FirstOrDefault(s => s.Id.Equals(reponseID));
            Organigramme.Insertion(n1, salarie);
           
            Console.WriteLine("Le salarié a été embauché! \n");
        }

        public void Licenciment() //Licenciment du salarié
        {
            Console.WriteLine("Quel salarié voulez-vous licencié ? (Insérer l'ID du salarié)");
            string reponseLicenciment = Console.ReadLine();
            Salarie salarie = ListeDeSalarie.FirstOrDefault(s => s.Id.Equals(reponseLicenciment)); // Renvoie le premier element qui correspond a la condition sinon renvoie null
            ListeDeSalarie.Remove(salarie);
            Organigramme.Retirer(salarie);
            Console.WriteLine("Le salarié a été licencié! \n");
        }
    }
}

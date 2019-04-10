using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Ado
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connexion a la Base de Donnée");
            Console.WriteLine("Host:");
            string h = Convert.ToString(Console.ReadLine());
            Console.WriteLine("database:");
            string db = Convert.ToString(Console.ReadLine());
            Console.WriteLine("user:");
            string u = Convert.ToString(Console.ReadLine());
            Console.WriteLine("mot de passe:");
            string pswd = Convert.ToString(Console.ReadLine());
            Requetes rqt = new Requetes(h, u, db, pswd);
            Console.WriteLine("Afficher menu True/False");
            Boolean choix1 = Convert.ToBoolean(Console.ReadLine());
            while (choix1)
            {

                Console.WriteLine("Choix");
                Console.WriteLine("0. Liste des joueurs");
                Console.WriteLine("1. Liste des joueurs par sponsor");
                Console.WriteLine("2. Liste des joueurs ayant la meme nation que leur sponsor");
                Console.WriteLine("3. Chiffre d'affaires des sponsors");
                Console.WriteLine("4. Insertion de Nadal");
                Console.WriteLine("5. Update de Nadal");
                Console.WriteLine("6. Delete de Nadal");
                int choix = Convert.ToInt32(Console.ReadLine());
                switch (choix)
                {
                    case 0:
                        Console.WriteLine("REQUETE 1");
                        Console.WriteLine(rqt.Listejoueurs());
                        break;
                    case 1:
                        Console.WriteLine("REQUETE 2");
                        Console.WriteLine(rqt.ListeJoueursSponsor());
                        break;
                    case 2:
                        Console.WriteLine("REQUETE 3");
                        Console.WriteLine(rqt.ListeJoueursSponsorNation());
                        break;
                    case 3:
                        Console.WriteLine("REQUETE 4");
                        Console.WriteLine("Chiffre d'affaires: {0}", rqt.MontantSponsor());
                        break;
                    case 4:
                        Console.WriteLine("Insertion de Nadal:");
                        rqt.InsertJoueurs();
                        Console.WriteLine(rqt.Listejoueurs());
                        break;
                    case 5:
                        Console.WriteLine("Update de Nadal:");
                        rqt.UpdateJoueurs();
                        Console.WriteLine(rqt.Listejoueurs());
                        break;
                    case 6:
                        Console.WriteLine("Delete de Nadal:");
                        rqt.DeleteJoueurs();
                        Console.WriteLine(rqt.Listejoueurs());
                        break;
                    default:
                        Console.WriteLine("Out of bands !");
                        break;
                }
                Console.WriteLine("Afficher menu Tennis True/False");
                choix1 = Convert.ToBoolean(Console.ReadLine());
            }




            Console.WriteLine("Afficher le menu Gesper? True/False");
            Boolean choix2 = Convert.ToBoolean(Console.ReadLine());
            while (choix2)
            {

                Console.WriteLine("Choix");
                Console.WriteLine("0. Cree Employer");
                Console.WriteLine("1. liste employe");
                Console.WriteLine("2. salaire employer");
                Console.WriteLine("3. update budget");
                Console.WriteLine("4. moyenne diplomeSup");
                Console.WriteLine("5. Mise a jour salaire");
                Console.WriteLine("6. Mase Salariale");
                Console.WriteLine("7. Super Cadre");

                int choix = Convert.ToInt32(Console.ReadLine());

                switch (choix)
                {
                    case 0:
                        Console.WriteLine("Cree Employer");
                        rqt.CallCreationEmployer();
                        break;
                    case 1:
                        Console.WriteLine("liste employe");
                        Console.WriteLine(rqt.CallEmployeDip());
                        break;
                    case 2:
                        Console.WriteLine("salaire employer");
                        Console.WriteLine(rqt.CallSalaireEmployer(3500, 6500));
                        break;
                    case 3:
                        Console.WriteLine("update budget");
                        rqt.CallMajBudget();
                        break;
                    case 4:
                        Console.WriteLine("moyenne diplomeSup");
                        Console.WriteLine(rqt.CallAvgDiplomeSup());
                        break;
                    case 5:
                        Console.WriteLine("mise a jour Salaire");
                        Console.WriteLine(rqt.MajSalaire("mmadi", 30));
                        break;
                    case 6:
                        Console.WriteLine("Masse Salariale");
                        Console.WriteLine(rqt.MSalariale("comptabilité"));
                        break;
                    case 7:
                        Console.WriteLine("Super Cadre");
                        Console.WriteLine(rqt.SuperCadre());
                        break;
                    default:
                        Console.WriteLine("En dehors, il faut faire un choix !");
                        break;
                }
                Console.WriteLine("Afficher le menu Call? True/False");
                choix2 = Convert.ToBoolean(Console.ReadLine());
            }
            Console.ReadLine();
        }
 
    }
}

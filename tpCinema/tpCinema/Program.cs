using System;
using System.Collections.Generic;
using ApiCinema;
using ApiPersistance;

namespace tpCinema
{
    class Program
    {
        public static bool IsNumerique(string chaineSaisie)
        {
            bool isNum = true;
            for (int i = 0; i < chaineSaisie.Length; i++)
            {
                if (!char.IsDigit(chaineSaisie, i))
                {
                    isNum = false;
                    Console.WriteLine("le caractère a la position " + (i + 1) + " n'est pas un chiffre");
                }
            }
            return isNum;
        }

        public static int SaisirEntier()
        {
            string valeurSaisie;
            do
            {
                valeurSaisie = Console.ReadLine();
            }
            while (!Program.IsNumerique(valeurSaisie));
            return Convert.ToInt32(valeurSaisie);
        }

        static void Main(string[] args)
        {
            string chaineSaisie;

            //Classe persistance s'en charge de la sauvegarde de données
            Cinema unCinema = Persistance.ChargerObjet("Cinema.save") as Cinema;    //transtipage / tenter de transformer l'objet à portée classe en cinema 
            if (unCinema == null)
            {
                Console.WriteLine("Quel est le nom de votre cinéma ?");
                chaineSaisie = Console.ReadLine();
                unCinema = new Cinema(chaineSaisie);
                Console.Clear();
            }

            int choix;
            bool continuer = true;
            do
            {

                Console.WriteLine("0- Sortir du programme");
                Console.WriteLine("1- Lister le nom des salles du cinéma {0}", unCinema.NomDuCinema);
                Console.WriteLine("2- Ajouter une salle au cinéma {0}", unCinema.NomDuCinema);
                Console.WriteLine("3- Supprimer une salle au cinéma {0}", unCinema.NomDuCinema);
                Console.WriteLine("4- Afficher les informations de la salle la plus grande");
                Console.WriteLine("5- Afficher la capacité (le nombre de places) totale du cinéma {0}", unCinema.NomDuCinema);

                choix = SaisirEntier();

                switch (choix)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("****************** Liste des salles *********************");
                        Console.WriteLine("");
                        /*
                         * Partie à compléter
                         * 
                         
                         * Ajoutez l'(ou les) instruction(s) qui permet(tent) de lister les noms des salles du cinéma
                         * 
                         * */
                        Console.WriteLine("");
                        Console.WriteLine("Entrez pour continuer... ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("****************** Ajout d'une salle *********************");
                        Console.WriteLine("");
                        /*
                        * Partie à compléter
                        * 
                        * Ajoutez l'(ou les) instruction(s) qui permet(tent) d'ajouter une salle au cinéma
                        * */
                        Console.WriteLine("");
                        Console.WriteLine("Entrez pour continuer... ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("****************** Suppression d'une salle *********************");
                        Console.WriteLine("");
                        /*
                        * Partie à compléter
                        * 
                        * Ajoutez l'(ou les) instruction(s) qui permet(tent) de supprimer une salle du cinéma
                        * */
                        Console.WriteLine("");
                        Console.WriteLine("Entrez pour continuer... ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("****************** Information sur la salle la plus grande *********************");
                        Console.WriteLine("");
                        /*
                          * Partie à compléter
                          * 
                          * Ajoutez l'(ou les) instruction(s) qui permet(tent) d'afficher les informations de la salle la plus grande
                          * */
                        Console.WriteLine("");
                        Console.WriteLine("Entrez pour continuer... ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("****************** Capacité total du cinéma *********************");
                        Console.WriteLine("");
                        /*
                         * Partie à compléter
                         * 
                         * Ajoutez l'(ou les) instruction(s) qui permet(tent) d'afficher le nombre total dont dispose le cinéma
                         * */
                        Console.WriteLine("");
                        Console.WriteLine("Entrez pour continuer... ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                                                                                          
                    case 0:
                        /*
                        * Partie à compléter
                        * 
                        * Ajoutez l'(ou les) instruction(s) qui permet(tent) de sauvegarder l'objet de type Cinema 
                        * dans un fichier nommé "Cinema.save"
                        * 
                        * */
                        continuer = false;
                        break;

                    default: break;
                }

            } while (continuer);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableauMenu
{
    class Program
    {
        static int[] tab = null;

        static int GetInteger(string message)
        {
            int nombre;
            string reponse;

            Console.WriteLine(message);
            reponse = Console.ReadLine();
            nombre = Convert.ToInt32(reponse);

            return nombre;
        }

        static string GetString(string message)
        {
            
            string reponse;

            Console.WriteLine(message);
            reponse = Console.ReadLine();


            return reponse;
        }
      
        
        static void InitTab()
        {
            int taille = GetInteger("Entrez une taille");

            tab = new int[taille];
            
        }

        static void SaisieTab()
        {
            if (tab == null)
            {
                Console.WriteLine("Il faut créer le tableau avant de pouvoir rentrer les données");
                Console.WriteLine(" Appuyez sur Entrée pour continuer ");
                Console.ReadLine();

            }
            else
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = GetInteger("Entrez un nombre pour la case" + i);
                }
            }
        }
        static void AfficheTab()
        {
            string nom;
            Console.WriteLine("Entrez le nom du tableau");
            nom = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(nom);
            Console.ReadLine();

            foreach (int element in tab)

            {
                Console.Write(element);
            }
           
            Console.WriteLine();
            Console.WriteLine("Appuyez sur Entrée pour continuer !!! ");
            Console.ReadLine();
           
        }

        static void Main(string[] args)
        {
            int choix;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Créer le tableau");
                Console.WriteLine("2 - Remplir le tableau");
                
                Console.WriteLine("3 - Afficher le tableau");
                
                Console.WriteLine("0 - quitter");

                choix = GetInteger("Entrez votre choix");

                if (choix == 1)
                {
                    InitTab();
                }

                if (choix == 2)
                {
                    SaisieTab();
                }

                if (choix == 3)
                {
                    AfficheTab();
                }

            } while (choix != 0);

        }
    }
}

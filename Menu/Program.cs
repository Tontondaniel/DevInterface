using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static int GetInteger ( string message)
        {
            int nombre;
            string reponse;

            Console.WriteLine(message);
            reponse = Console.ReadLine();
            nombre = Convert.ToInt32(reponse);

            return nombre;


        }

        static string GetString( string message)
        {
            string reponse;

            Console.WriteLine(message);
            reponse = Console.ReadLine();

            return reponse;

        }


        static void Multiples ( int N)
        {
            for (int i= 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", i, N, i * N);
                
            }
            Console.ReadLine();
        }

        static void SommeMoyenne( int i)
        {
            int moyenne = 0;
            int N1 = 0;
            int N = 0;

            while (i!=0)
            {
                N += i;
                i++;
                N1 = N1 + 1;
                moyenne = N / N1;

                i = GetInteger("entrez un nombre");

            }

            Console.WriteLine();
            Console.WriteLine("La Somme des entiers est de : " + N);
            Console.WriteLine("La Moyenne est de : " + moyenne);
            Console.ReadLine();

            

        }

        static void CompteVoyelle ( string saisie)
        {
            int N = 0;
            Char[] voyelle = new Char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };

            

            foreach ( char c in saisie)
            {
                if (Char.IsLetter(c))
                {
                    if (voyelle.Contains(c))
                        N++;
                }
            }
            Console.WriteLine("Le Nombre de Voyelles présentent  est de {0}", N);
            Console.ReadLine();

        }

        static void Lettres ( string saisie)
            {
            string mot = saisie;
            int compteur = 0;
            int N = 0;
            char lettre ;

            
            Console.WriteLine("Entrer une lettre !!!!");
            lettre = Convert.ToChar(Console.ReadLine());

            for (N = 0; N <mot.Length; N ++)
            {
                if (mot[N] == lettre)
                    compteur++;
            }
            Console.WriteLine(" il y a {0} lettre(s) {1} !!!", compteur, lettre);
            Console.ReadLine();

        }
        static void Main(string[] args)
        {

            int choix;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine(" 1- Multiples");
                Console.WriteLine(" 2- Somme et Moyenne");
                Console.WriteLine(" 3- Recherche du nombre de voyelles");
                Console.WriteLine(" 4- Recherche du nombre de caracteres ");
                Console.WriteLine(" 0- Quitter");

                choix = GetInteger("Entrez votre choix");


                if (choix == 1)
                {
                    int N;
                    N = GetInteger("Entrez un entier");

                    Multiples(N);
                }
                if (choix == 2)
                {
                    int i;
                    i = GetInteger("Entrez un entier");

                    SommeMoyenne(i);

                }
                if (choix == 3)
                {
                    string saisie;
                    saisie = GetString("Entrez un mot");

                    CompteVoyelle(saisie);
                    }
                if (choix == 4)
                {
                    

                    string saisie;
                    saisie = GetString("Entrez un mot ou une phrase !!!!");

                    Lettres(saisie);
                    
                }

            } while (choix != 0);
        }
    }
}

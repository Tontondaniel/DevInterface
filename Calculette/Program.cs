using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculette, V1.0, 07/02/18");

            string saisie;
            double entier1;
            double entier2;
            string operateur;
            double resultat;

            Console.WriteLine("Entrez un entier");
            saisie = Console.ReadLine();
            entier1 = Convert.ToDouble(saisie);

            Console.WriteLine("Entrez un opérateur");
            operateur = Console.ReadLine();

            Console.WriteLine("Entrez un second entier");
            saisie = Console.ReadLine();
            entier2 = Convert.ToDouble(saisie);

            if (operateur =="+")
                { resultat = entier1 + entier2;
                Console.WriteLine(resultat);
                }

            else if (operateur == "-")
                { resultat = entier1 - entier2;
                Console.WriteLine(resultat);
            }

            else if (operateur == "*")
                { resultat = entier1 * entier2;
                Console.WriteLine(resultat);
            }

            else if (operateur == "/")
                { resultat = entier1 / entier2;
                Console.WriteLine(resultat);
            }

            else
                { Console.WriteLine(" vous avez entrez un mauvais operateur !!!!"); }

           
            Console.ReadLine();



        }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FonctionLettres
{
    class Program
    {

        static int Lettres(string phrase)

        {

            string mot = phrase;
            int compteur= 0;
            int N = 0;
            char lettre;
           
            Console.WriteLine("saisir une lettre");
            lettre = Convert.ToChar(Console.ReadLine());
            
                for (N = 0; N<mot.Length ; N++ )

                {
                    if (mot[N] == lettre)
                        compteur++;

                }
            Console.WriteLine(" il y a {0} lettre(s) {1} !!!", compteur, lettre);

            return compteur; 
           

        }
        static void Main(string[] args)
        {
            string phrase;

            Console.WriteLine("Entrer une phrase ou un mot  !!!!");
            phrase = Convert.ToString(Console.ReadLine());
           
           int compteur = Lettres(phrase);

            
        }
        
    }


}++
            
        

    


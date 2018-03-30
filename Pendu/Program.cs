using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu
{
    class Program
    {
        static void pendu(string saisie)
        {
            Console.WriteLine(" Vous êtes Pendu !!!!");
            Console.WriteLine(" le Mot secret était {0} ", saisie);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string[] MotCache = null;
            string[] Motsecret = null;
            string saisie;
            int essai = 10;
            
            bool Fin = false;
            string lettre;
            int i;

            

                Console.WriteLine("Joueur 1 : Entrez un mot !!!");
                saisie = Console.ReadLine();
            Motsecret = new string[saisie.Length];
            MotCache = new string[saisie.Length];


                Console.Clear();

            for (i = 0; i < saisie.Length; i++)
                {
                    Motsecret[i] =(saisie.Substring(i,1));
                    MotCache[i] = "_";
                     

                }
           

            do
            {
                Fin = true;
                Console.WriteLine(" Joueur 2 : Entrez une lettre ( Vous disposez de {0} essai(s) avant d'être pendu !!!!) ", essai);
                lettre = (Console.ReadLine());


                for (i = 0; i < saisie.Length; i++)
                {
                    if (Motsecret[i] == lettre)
                    {
                        MotCache[i] = lettre;
                       
                    }
                    
                }
                essai--;


                for (int j= 0; j < saisie.Length; j++)
                {
                    Console.Write(MotCache[j]);
                    if (MotCache[j] == "_")
                    {
                        Fin = false;
                        
                    }
                    
                }
                Console.WriteLine();
                if (essai == 0)
                {
                    pendu(saisie);
                }
            }
            while (Fin == false);
            Console.WriteLine(" bravo vous n'êtes pas pendu !!! vous avez trouvé le mot secret ");
            Console.WriteLine(" Au tour du joueur 2 de faire deviner le mot ");
            Console.ReadLine();

        }
    }
}

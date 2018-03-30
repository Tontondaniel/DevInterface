using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            double X;
            double N;
            double i = 0;
            double resultat = 0;


            Console.WriteLine("Entrer un entier N ");
            N = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrer unentier X ");
            X = Convert.ToDouble(Console.ReadLine());

            for ( i = 1; i < X; i++)
            {
                if (i > N)
                    break;


                resultat = i * X;
                
                Console.WriteLine(i + "*" + X + "=" + resultat);
                Console.ReadLine();

                
           
               
            }

            Console.WriteLine("Bravo voici la table des : " + X);
            Console.ReadLine();
        }
    }
}


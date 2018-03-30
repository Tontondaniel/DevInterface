using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3bases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculatrice V1.0, 06/02/18");
            Console.WriteLine();


            string saisie1;
            string saisie2;
            int A;
            int B;
            int C;

            Console.WriteLine("Veuillez entrer un nombre  A ") ;
            saisie1 = Console.ReadLine();
            A = Convert.ToInt32(saisie1);  
            

            Console.WriteLine("Veuillez entrer un nombre  B");
            saisie2 = Console.ReadLine();
            B = Convert.ToInt32(saisie2);
            C = A + B;

            Console.WriteLine("le résultat de l'addition est : " + C);
            Console.ReadLine();
        }
    }
}



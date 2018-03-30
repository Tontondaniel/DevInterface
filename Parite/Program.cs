using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parite
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            double entier;
            double reste;

            Console.WriteLine("Parité, V1.0, 07/02/18");
           

            Console.WriteLine("Entrez un entier : ");
            saisie = Console.ReadLine();

            entier = Convert.ToDouble(saisie);

            reste = entier % 2;

            if (reste == 0) 
            { Console.WriteLine(" L'entier est pair ! "); }

            else
            { Console.WriteLine(" L'entier est impair ! "); }

            Console.ReadLine();

         
        }
    }
}

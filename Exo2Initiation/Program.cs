using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2Initiation
{
    class Program
    {
        public static double Aire { get; private set; }

        static void Main(string[] args)
        {
            string saisie;
            double rayon;
            double perimetre;

            Console.WriteLine( " Périmètre et surface du Cercle ( v1.0, 06/02/18) " );

            Console.WriteLine();

            Console.WriteLine("Entrez la valeur du rayon en cm : ");
            saisie = Console.ReadLine();

            rayon = Convert.ToDouble(saisie);

            perimetre = 2 * Math.PI * rayon;

            Aire= Math.PI * (rayon * rayon);

            Console.Write("Ce cercle est de rayon : " + rayon + " cm ") ;

            Console.WriteLine();

            Console.Write("Son perimetre est de  : " + perimetre + " cm " ) ;

            Console.WriteLine();

            Console.Write("La surface de ce Cercle est de : " + Aire + "cm² ") ;
            
            Console.WriteLine();

            Console.ReadLine();
        }
    }
    

}

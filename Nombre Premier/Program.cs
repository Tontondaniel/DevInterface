using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombre_Premier
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine(" ==== Nombre Premier , V1.0, 07/03/2018 ====");

            int Nbr;




            Console.WriteLine("Entrer un nombre ( 0 pour arreter ).");
            Nbr = Convert.ToInt32(Console.ReadLine());


            while (Nbr != 0)
            {
                int n = 2;
                while ((Nbr % n != 0) && (n < Math.Sqrt(Nbr))) // Si Nbr modulo de n différent de 0 et  n < à la racine carré de Nbr alors on incrémente n de 1
                                                               // n doit rester inférieur  à la racine carré de Nbr

                {
                    n++;
                }

                if ((Nbr % n == 0) && (Nbr!=2))
                {
                    Console.WriteLine(" Ce Nombre n'est pas Premier !!");
                }

             
                else
                {
                    Console.WriteLine(" Ce nombre est Premier !!!");
                }

                Console.WriteLine("Entrer un nombre ( 0 pour arrêter )");
                Nbr = Convert.ToInt32(Console.ReadLine());

            }

        }
    }
}
    



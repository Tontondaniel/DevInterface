using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somme_Intervalle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Somme d'un Intervalle, V1.0, 12/02/18");

            int Nbr1, Nbr2, somme= 0;

            Console.WriteLine("Entrez un nombre : ");
            Nbr1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez un nombre : ");
            Nbr2 = Convert.ToInt32(Console.ReadLine());
            if (Nbr1 < Nbr2)

                for (int i = Nbr1 ; i <= Nbr2; i++)
                {
                    Console.WriteLine(i);
                    somme = somme + i;
                }
            else
                Console.WriteLine("le premier nombre doit etre inférieur au second nombre !!! ");
            Console.ReadLine();

            Console.WriteLine("La somme des entiers compris dans l'intervalle = " + somme);
            Console.ReadLine();

        }
    }
}

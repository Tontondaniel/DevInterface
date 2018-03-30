using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somme_Entier_Inf_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre inférieur à N, V1.0, 12/02/18");
            int nombre, somme = 0;

            Console.WriteLine("Entrez un nombre !");
            nombre = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nombre; i++)
            {
                Console.WriteLine(i);
                somme = somme + i;
            }

            

            Console.WriteLine("La somme des entiers inférieurs à N est de : " + somme);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CréationTab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab;
            int taille;

            Console.WriteLine(" Entrez le nombre de case ");
            taille= Convert.ToInt32(Console.ReadLine());

            tab = new int[taille];

            for (int i = 0; i < taille; i++)
            {
                Console.WriteLine("Entrez la valeur de la case " + i);
                tab[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine();
            Console.ReadLine();


            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();

         
        }
    }
}

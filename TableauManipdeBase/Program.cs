using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableauManipdeBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau;
            int taille;

            Console.WriteLine("Entrez la taille du tableau");
            taille = Convert.ToInt32(Console.ReadLine());

            tableau = new int[taille];

            for (int i = 0; i < taille; i++)
            {
                Console.WriteLine("Entrez la case " + i);
                tableau[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < taille; i++) 
            {
                Console.Write(tableau[i] + " ");
            }
            Console.WriteLine();

            foreach( int element in tableau)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

        }
    }
}

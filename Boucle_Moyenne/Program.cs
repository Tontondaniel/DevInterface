using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucle_Moyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moyenne, V1.0, 12/02/18");
            double moyenne = 0;
            double N = 0;
            double N1 = 0;
            double i;
            

            Console.WriteLine("entrez un nombre :");
            i = Convert.ToDouble(Console.ReadLine());

          

            while (i != 0)
            {
                N += i;
                i++;
                N1 = N1 + 1;
                moyenne = N / N1;

                
             



                Console.WriteLine("entrez un nombre :");
                i = Convert.ToDouble(Console.ReadLine());
            }
           
             
            Console.WriteLine();
            Console.WriteLine(" la somme des entiers est de : " + N);
            Console.WriteLine(" La moyenne est de : " + moyenne);
           
            Console.WriteLine();
            Console.ReadLine();

            


        }
    }
}

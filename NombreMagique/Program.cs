using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreMagique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre Magique version 1.0 , 13/03/2018");


            int n;

            Random generateur = new Random();
            int secret = generateur.Next(1, 1001);

            do
            {
                Console.WriteLine("Entrer un entier");
                n = Convert.ToInt32(Console.ReadLine());

                if (n > secret)
                {
                    Console.WriteLine(" le nombre est trop grand !!!");
                }

                if (n < secret)
                {
                    Console.WriteLine(" le nombre est trop petit !!!");
                }


            } while (n != secret);

            Console.WriteLine(" Bravo vous avez trouvé  le nombre magique {0}!!!!!  <3 <3 <3 <3 <3 ", secret);
            Console.ReadLine();


           


            

        }
    }
}

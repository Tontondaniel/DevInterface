using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moyenne, V1.0, 12/02/18");
            
            
            
            double i;
            double Nmi = 0;
            double Nma = 0;

            Console.WriteLine("entrez un nombre :");
            i = Convert.ToDouble(Console.ReadLine());

            Nmi = i;

            while (i != 0)
            {
             


                if (i < Nmi)
                    Nmi = i;


                else if (i > Nma)
                    Nma = i;



                Console.WriteLine("entrez un nombre :");
                i = Convert.ToDouble(Console.ReadLine());
            }


            Console.WriteLine();
            
            Console.WriteLine("le nombre min est : " + Nmi);
            Console.WriteLine("le nombre max est : " + Nma);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

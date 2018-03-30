using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyennePonderee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MoyennePondérée v1.0, 06/02/18");
                Console.WriteLine();

            
            string DS;
            string Intero;
            string TP;
            double A;
            double B;
            double C;
            double coefDS = 3;
            double coefInt = 2;
            double coefTP = 1;
            double D;

            Console.WriteLine("veulliez entrer la note du DS");
            DS = Console.ReadLine();

            A = Convert.ToDouble(DS);

            Console.WriteLine("veulliez entrer la note de l'intero");
            Intero = Console.ReadLine();

            B = Convert.ToDouble(Intero);

            Console.WriteLine("veulliez entrer la note du TP");
            TP = Console.ReadLine();

            C = Convert.ToDouble(TP);

            D = ((C + (A * coefDS) + (B * coefInt)) / (coefTP + coefDS + coefInt));

            Console.WriteLine(" La moyenne est de : " + D);
            Console.ReadLine();

        }

    }
}

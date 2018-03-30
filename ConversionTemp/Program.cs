using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionTemp
{
    class Program
    {
        static void Main(string[] args)
        {//C=(5/9)(F-32)

            Console.WriteLine("Conversion De F° en C°, V1.0, 06/02/18");
            Console.WriteLine();

            string saisie;
            double F;
            double C;

            Console.WriteLine("Veulliez entrer la Temperature souhaitée : ");
            saisie = Console.ReadLine();
            F = Convert.ToDouble(saisie);

            C = (5.0 / 9.0) * (F - 32);

            Console.WriteLine("La température saisie de : " + F + "F° " + " est égale à : " + C + "C°");
            Console.ReadLine();


        }
    }
}

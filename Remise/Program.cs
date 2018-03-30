using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remise, V1.0, 07/02/18");


            string saisie; 
            double PU;
            double QTECOM;
            double PAP = 0;
            double PORT =6;
            double REM =0 ;
            double TOT = 0;


             // Rappel de calcul TOT = PU * QTECOM , PAP = PU * QTECOM + PORT - REM

            Console.WriteLine("entrez le prix du produit ");
            saisie = Console.ReadLine();
            PU = Convert.ToDouble(saisie);

            Console.WriteLine("entrez la quantité commandée ");
            saisie = Console.ReadLine();
            QTECOM = Convert.ToDouble(saisie);

            TOT = PU * QTECOM;

            Console.WriteLine("Le Prix ht est de : " + TOT + " euros");
            Console.ReadLine();


            if (TOT < 500)
            { PORT = (TOT * 2) / 100; }
                if (PORT < 6)
                { PORT = 6; }

            else 
            { PORT = 0;  }

          
            if (TOT >= 100 & TOT <= 200)
            { REM = (TOT * 5) / 100; }

            else if (TOT > 200)
            { REM = (TOT * 10) / 100; }

            else
            { REM = 0; }

            PAP = (TOT + PORT - REM);

            Console.WriteLine("Le Prix total est de : " + PAP + " Euros");
            Console.WriteLine("Avec des frais de Port de : " + PORT + " Euros");
            Console.WriteLine(" Vous bénéficiez d'une remise de " + REM + " Euros");

            Console.ReadLine();

        }
    }
}

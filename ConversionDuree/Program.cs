using System;

namespace ConversionDuree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversion de durée exprimée en secondes, V1.0, 06/02/18");
               
            string saisie;
            int Sec = 01;
            int Minutes = 0;
            int Heures = 0;

            Console.WriteLine("Entrez une durée en seconde :");
            saisie = Console.ReadLine();
            Sec = Convert.ToInt32(saisie);
            // % sert a récupérer le reste de la soustraction , necessaire pour pouvoir repporter les sec vers les minutes , vers les heures 
            Heures = (Sec / 3600);
            Minutes = (Sec % 3600) / 60;               
            Sec = (Sec % 3600) - (Minutes * 60); 
           
            Console.WriteLine(Heures + "H " + Minutes + "M " + Sec + "S ");
            Console.ReadLine(); 

            
        }

    }
}

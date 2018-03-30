using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Participation, V1.0, 08/02/18");

            string saisie;
            double enfants;
            double Nbr = 0;
            
            double salaire = 0;
            double Participation = 0;
            

            Console.WriteLine("Saississez votre statut ( C pour Célibataire et M pour Marié) : ");

            saisie = Console.ReadLine();

            switch (saisie)
            {
                case "C":
                    Console.WriteLine(" Vous êtes célibataire");
                        saisie = Console.ReadLine();
                    Participation = 20;
                        
                    break;

                case "M":
                    Console.WriteLine(" Vous êtes marié");
                        saisie = Console.ReadLine();
                    Participation = 25;
                    break;
            }

            

            Console.WriteLine("Nombre d'enfants :  ");
            saisie = Console.ReadLine();
            enfants = Convert.ToDouble(saisie);

            Nbr =  Participation + (10 * enfants);

            Console.WriteLine("Quel est votre salaire ? ");
            saisie = Console.ReadLine();
            salaire = Convert.ToDouble(saisie);

            if (salaire <= 1200)
            { Nbr = (Nbr + 10); 
                if (Nbr > 50)
                { Nbr = 50; }
            }

            else
            {
                Nbr = Nbr + 0;
                if (Nbr > 50)
                { Nbr = 50; }
            }



            Console.WriteLine("Vous avez le droit à : " + Nbr + " % de participation");
            Console.ReadLine();
        }
    }
}

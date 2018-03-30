using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableauMajorité
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" Majorité , exo tableau, V 1.0, 26/03/2018");

            DateTime dateN = DateTime.Now;

            Console.WriteLine("Entrez Votre Nom et Prenom");
            string nom = Console.ReadLine();
            while (dateN.Day != 0 && nom != "Johnny Hallyday")
            {
                Console.WriteLine("Entrez votre date de naissance (jj/ mm/ AAAA)!!!! ");
            dateN = Convert.ToDateTime(Console.ReadLine());

            TimeSpan ts = DateTime.Now - dateN;
          
                if (ts.Days / 365 > 18 && ts.Days / 365 <= 120 && dateN.Year!= 1924)
                {
                    Console.WriteLine(" Bien joué {0}, vous avez {1} ans, vous êtes donc majeur..hourra !!!",nom, ts.Days / 365);
                    Console.ReadLine();
                }

                if (ts.Days / 365 > 120)
                {
                    Console.WriteLine(" Oups {0} Vous avez {1} ans ; Vous etes majeur et probablement mort... !!!",nom,  ts.Days / 365);
                    Console.ReadLine();
                }
                if (dateN.Year == 1924)
                {
                    Console.WriteLine(" Vous êtes né en 1924, oh mon dieu  ...GNNNNNNNÉÉÉÉ, Bonjour charles !!!");
                    Console.ReadLine();
                }

                if (ts.Days / 365 < 18)
                {
                    Console.WriteLine("Désolé {1}, tu as  {1} ans ; tu n'es pas majeur !!!", nom, ts.Days / 365);
                    Console.ReadLine();

                }               

            }
            if (nom == "Johnny Hallyday")
            {
                Console.WriteLine(" Alors , comment se passe ta tournée en boîte?");
                Console.ReadLine();

               
            }
            Console.WriteLine("A Bientôt!!!!!");
            Console.ReadLine();

        }
    }
}



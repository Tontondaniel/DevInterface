using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteJeuMoyVie
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            int Age = 0;
            int Nombre = 0;
            int Nombre1 = 0;
            int Nombre2= 0;
            int Nombre3= 0;


            Console.WriteLine(" Calcul du nombre de Jeunes, de Moyens et de Vieux , sélectionner 0 pour arreter la saisie, v1.0, 07/03/2018");

            Console.ReadLine();

             Console.WriteLine("Entrer un âge");
             i = Convert.ToInt32(Console.ReadLine());

            
            while (i != 0)
            {
                Age++;
                
                Console.WriteLine("entrer un âge");
                i = Convert.ToInt32(Console.ReadLine());

                if (i < 20)
                { Nombre1++; }
                    
                if (i > 40)
                { Nombre2++; }

                if (i >= 20 & i <= 40)
                { Nombre3++; }

               
            }
            Console.WriteLine("Vous avez déclaré :" + Age + " personnes !!!");
            Console.WriteLine("Le nombre de jeunes est de : " + Nombre1);
            Console.WriteLine("Le nombre de Moyens est de : " + Nombre3);
            Console.WriteLine("Le nombre de Vieux est de : " + Nombre2);
            Console.ReadLine();
            
        }
        


    }
}

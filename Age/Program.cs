using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Age, V1.0, 07/02/18");

            string saisie;
            int annee;
            int age;
            Console.WriteLine("Entrez votre année de naissance ");
            saisie = Console.ReadLine();

            annee = Convert.ToInt32(saisie);

            age = 2018 - annee;

            Console.WriteLine("Vous avez : " + age+ " Ans !!! ");

            Console.ReadLine();

            if (age >=18)
            { Console.WriteLine("Vous etes majeur !!! "); }

            else
            { Console.WriteLine("Vous n'etes pas majeur !!! "); }

            Console.ReadLine();

        }
    }
}

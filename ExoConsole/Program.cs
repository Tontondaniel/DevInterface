using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Exercice Console, V1.0, 06/02/18");

            Console.WriteLine();

            string saisie;
            int code = 0;
            char Car;
      
            Console.WriteLine("Entrez un Code ");
           saisie= Console.ReadLine();

            code = Convert.ToInt32(saisie);

            Car = Convert.ToChar(code);

            Console.WriteLine("cet unicode est égale à : " + Car);

            Console.ReadLine();

        }
    }
}

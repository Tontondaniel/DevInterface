using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreVoyelles
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            string saisie;
            Char[] voyelle = new Char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y'};
            
            Console.WriteLine("Entrer un mot");
            saisie = Console.ReadLine();

            
            
          

            foreach (char c in saisie)
            {

                if (Char.IsLetter(c))

                {
                    if (voyelle.Contains(c))
                        N++;
                  
                }
            }
            Console.WriteLine("Le nombre de Voyelles présentent est de : " + N);
            Console.ReadLine();

        }
    }
}

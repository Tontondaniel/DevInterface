using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_tri
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab = { "Polo", "Jean_Miche", "Raoul", "Dartagnan", "Michel" };

           
           foreach ( string p in tab)
            {
                Console.Write(p + " ");
            }
            Console.WriteLine();
            Array.Sort(tab);
            for (int j = 0; j <tab.Length ; j++)
            {
                

                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i].CompareTo(tab[i + 1]) > 0)
                    {
                        string tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                    }
                }
                foreach (string p  in tab)
                {
                    Console.Write(p + " ");
                }

                Console.WriteLine();

            }
            
            
        }
    }
}

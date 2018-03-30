using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableauPrenom
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab = { "Polo", "Jean_Miche", "Raoul", "Dartagnan", "Michel" };

            string prenom;
            int position = -1;

            Console.WriteLine("Entrez un Prénom");
            prenom = Console.ReadLine();

            for (int i = 0; i < tab.Length; i++)

            {
                if (prenom ==tab[i])
                {
                    position = 1;
                }
            }

            if (position ==-1)
            {
                Console.WriteLine("Désolé , prenom pas trouvé !!!!");
            }

            else
            {
                Console.WriteLine("Prénom trouvé en " + position);
                for (int i = position; i < tab.Length - 1; i++)
                {
                    tab[i] = tab[i + 1];
                }
                tab[tab.Length - 1] = "";

                foreach (string p  in tab)

                {
                    Console.WriteLine(p);
                }

                Console.ReadLine();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FonctionMenu
{
    class Program
    {
        static int Multiplication(int table)

        {
            int x = 1;

            while (x <= 10)
            {


                Console.WriteLine("{0} * {1} = {2} ", x, table, x * table);
                x++;
            }
            return x;
        }

        static int Lettres(string phrase)

        {

            string mot = phrase;
            int compteur = 0;
            int N = 0;
            char lettre;

            Console.WriteLine("saisir une lettre");
            lettre = Convert.ToChar(Console.ReadLine());

            for (N = 0; N < mot.Length; N++)

            {
                if (mot[N] == lettre)
                    compteur++;

            }
            Console.WriteLine(" il y a {0} lettre(s) {1} !!!", compteur, lettre);

            return compteur;


        }
        static int NombresVoyelles(int N)
        {

            string saisie;
            Char[] voyelle = new Char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };

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

            return N;

        }


        static double Moyenne()
        {
            Console.WriteLine("Moyenne, V1.0, 12/02/18");

            double moyenne = 0;
            double N = 0;
            double N1 = 0;
            double i = 0; 

            while (i != 0)
            {
                N += i;
                i++;
                N1 = N1 + 1;
                moyenne = N / N1;






                Console.WriteLine("entrez un nombre :");
                i = Convert.ToDouble(Console.ReadLine());
            }


            Console.WriteLine();
            Console.WriteLine(" la somme des entiers est de : " + N);
            Console.WriteLine(" La moyenne est de : " + moyenne);

            Console.WriteLine();
            Console.ReadLine();

            return moyenne;

         
        }
        static void Main(string[] args)
        {


            string Saisie;
           
            Console.WriteLine("1- Multiples");
            Console.WriteLine("2- recherche du nombre de lettres");
            Console.WriteLine("3- Recherche du nombre de Voyelles");
            Console.WriteLine("4- Somme et Moyenne");
            Console.WriteLine(" Entrez votre option (0 pour sortir)");
            Saisie = Convert.ToString(Console.ReadLine());


           

                

             switch ( Saisie)
                {

                case "1":

                    {
                        Console.WriteLine(" Table de Mutiplication");
                        int table = 1;

                        while (table != 0)


                        {
                            Console.WriteLine("Entrer un nombre , entrer '0' pour mettre fin au programme !!!!");
                            table = Convert.ToInt32(Console.ReadLine());

                            int x = Multiplication(table);
                        }



                        Console.ReadLine();

                        break;
                    }

                case "2":
                    {

                        Console.WriteLine("Recherche du nombre de lettres");
                        string phrase;

                        Console.WriteLine("Entrer une phrase ou un mot  !!!!");
                        phrase = Convert.ToString(Console.ReadLine());

                        int compteur = Lettres(phrase);
                    }
                    break;



                case "3":

                    { Console.WriteLine("Recherche du nombre de Voyelles");


                        


                        int N = NombresVoyelles();
                    }

                    break;


                case "4":

                    {
                        
                        double i;


                        Console.WriteLine("entrez un nombre :");
                        i = Convert.ToDouble(Console.ReadLine());
                       

                        double moyenne = Moyenne(i);

                    }
                    break;








                }
            


        }

         static int NombresVoyelles()
        {
            throw new NotImplementedException();
        }

         static double Moyenne(double i)
        {
            throw new NotImplementedException();
        }
    }
}

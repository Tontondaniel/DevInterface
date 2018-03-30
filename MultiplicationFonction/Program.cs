using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationFonction
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
        static void Main(string[] args)
        {

            Console.WriteLine(" Table de Mutiplication");
            int table = 1;
            
            while (table !=0)


            { Console.WriteLine("Entrer un nombre , entrer '0' pour mettre fin au programme !!!!");
                table = Convert.ToInt32(Console.ReadLine());

                int x = Multiplication(table); }



            Console.ReadLine();
        }
        
    }
    
}

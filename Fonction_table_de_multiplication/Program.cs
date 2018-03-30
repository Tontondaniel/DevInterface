using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonction_table_de_multiplication
{
    class Program

    {


        static void TabledeMultiplication(int table)

        {
            int x = 1;

            while (x <= 10)
            { Console.WriteLine("{0} * {1} = {2} ", x, table, x * table);
                x++;
            }

        }


    }
     static void Main (string[] args)
    {
        int table;

        Console.WriteLine("Entrer un entier ");
        table = Convert.ToInt32(Console.ReadLine());

        TabledeMultiplication(table);

    }
}

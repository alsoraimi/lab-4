using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter an integer thats greater than 0 but less than 10.");


            int Num = int.Parse(Console.ReadLine());              //name integers
            int result = Num;                                     //user input                      

            for (int i = 1; i < Num; i++)       // input loop
            {
                result = result * i;
                Console.WriteLine("{0}*{1}", Num, i);
            }
            Console.WriteLine(result);



        }
    }
}

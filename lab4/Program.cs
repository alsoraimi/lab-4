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

            bool askToContinue = false;
            do

            {
                //Console.WriteLine("please enter an integer thats greater than 0 but less than 10.");

             //  Console.WriteLine(GetValidInteger());

                int Num = GetValidInteger();              //name integers
                int result = Num;                                     //user input                      

                for (int i = 1; i < Num; i++)       // input loop
                {
                    result = result * i;
                    Console.WriteLine("{0}*{1}", Num, i);
                }
                Console.WriteLine("the factorial of {0} is {1}", Num, result);

                Console.WriteLine("do you want to try again, ?" + " " + "(Y/N)"); // add user input if they want to try again
                if (Console.ReadLine().ToUpper() == "Y")
                    askToContinue = true;
                else
                {
                    Console.WriteLine("thanks for trying!");
                    return;
                }
            } while (askToContinue);
        }


        public static int GetValidInteger()           //add method for validation and input
        {

            int input;


            Console.WriteLine("please enter an integer that is greater than 0 but less than 10: ");


            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("input is not an integer, please enter an integer!");

            }
            return input;
        }
    }
}
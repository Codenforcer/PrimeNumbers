// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting the variables.
            int n, i, m, check = 0;

            // Ask user to input a number to check if it is a prime number (greater than 1 and divided by 1 or itself).
            Console.WriteLine("Please input a number to check if it is a prime number: ");
            int userNum = int.Parse(Console.ReadLine());

            // Divide userNum by 2 and save to a variable. This will be used to see if num divides by any other.
            n = userNum / 2;
            Console.WriteLine(11 % 4);
            

          /* Set i to 2 iterate through numbers to n to check if the numbers divid with userNum using nested if
           statement. If no number divides with userinput using modulus then set check to 1 and breakout.*/
            for (i = 2; i < n; i++)
            {
             
                if (userNum % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    check = 1;
                    break;
                }
            }
            // if check is still equals 0 then number is a prime number.
            if (check == 0)
            {
                Console.WriteLine("This number is a prime number");
            }
            
        }
    }
}




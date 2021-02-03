/***************************************************************
* Name        : ListsFibonacciNumbers
* Author      : Anthony Hamlin
* Created     : 02/03/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : This program generate a Fibonacci sequence with user input
*               Input:  User input - two prompts for whole numbers
*               Output: A list collection of sequenced Fibonacci numbers        
***************************************************************/
using System;
using System.Collections.Generic;
using System.Numerics;  // Really big numbers !!

namespace ListsFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creatw a lists bassed on the Fibonacci sequence
            Console.WriteLine("******************************************************************");
            Console.WriteLine(" We are going to create a Fibonacci sequence.");
            Console.WriteLine(" Use some caution when entering numbers at the prompts.");
            Console.WriteLine(" Large numbers could crash the program.");
            Console.WriteLine(" You can choose a starting number that devivates from ");
            Console.WriteLine(" the standard known sequence, i.e., start at 4, 6, 7, 9...etc.");
            Console.WriteLine("\n******************************************************************");
            Console.WriteLine();  //space in output

            // list to hold our sequence
            var FibonacciList = new List<BigInteger>
            {

            };

            try
            {
                Console.Write("Enter a number for the sequence starting point: ");
                // var FibonacciStarter = Convert.ToInt64(Console.ReadLine());  // to small
                var FibonacciStarter = BigInteger.Parse(Console.ReadLine());

                Console.Write("Enter how many sequence values you want returned: ");
                var returnCount = Convert.ToInt32(Console.ReadLine());

                //check for 0 (zero) as an input
                if (FibonacciStarter == 0)
                {
                    FibonacciList.Add(FibonacciStarter);
                    FibonacciStarter = 1;
                    FibonacciList.Add(FibonacciStarter);
                }
                else
                {
                    // if not zero we need to start with a least two items in the list
                    FibonacciList.Add(FibonacciStarter);
                    FibonacciList.Add(FibonacciStarter);
                }

                // generate the Fibonacci sequence 
                int counter = (returnCount - 2);
                while (counter > 0)
                {
                    //get consecutive previous items from list
                    var lastItem = FibonacciList[FibonacciList.Count - 2];
                    var lastResult = FibonacciList[FibonacciList.Count - 1];

                    // create a new lastResult
                    FibonacciList.Add(lastItem + lastResult);

                    counter--;
                }
                Console.WriteLine();  //space in output

                // output generated sequence
                foreach (var item in FibonacciList)
                {
                    Console.Write(item + " ");
                }
                
            }
            catch (FormatException e)
            {
                Console.WriteLine("\n!!! Error - User Input Format Exception !!! You must enter a whole number.");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n\n\n\n\n");

        }
    }
}

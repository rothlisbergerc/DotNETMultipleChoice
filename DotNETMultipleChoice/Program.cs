using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETMultipleChoice{
        // Author: Cheryl Rothlisberger
        // Date: 4/27/21

        // This program will prompt a user to enter a character corresponding to a
        // multiple choice answer. The computer will respond with a different message
        // depending on which answer the user chooses.

        class Program
        {
            static void Main(string[] args)             
        {
            string repeat = "";

                while (repeat != "d" )
                {
                    Console.WriteLine("Is privacy a right?");
                    Console.WriteLine("A. Yes");
                    Console.WriteLine("B. No");
                    Console.WriteLine("C. Who is this?");
                    Console.WriteLine("D. Exit");
                    Console.WriteLine();
                    Console.Write("Enter your choice: ");

                    string userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "a":
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine("Google wants to know your location.");
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine();
                            break;
                        case "b":
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine("Enable your webcam and ");
                            Console.WriteLine("await further instructions.");
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine();
                            break;
                        case "c":
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine("CEASE YOUR INVESTIGATIONS");
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine();
                            break;
                        default:
                            repeat = Console.ReadLine();
                            break;
                    }
                }

                Console.ReadKey();
            }
        }
    }


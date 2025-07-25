using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1-10): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number >= 1 && number <= 10)
                {
                    Console.WriteLine($"\nMultiplication Table for {number}:\n");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{number} x {i} = {number * i}");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Number must be between 1 and 10.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter an integer.");
            }
        }
    }
}

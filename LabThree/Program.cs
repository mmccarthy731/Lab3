using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!\n");

            string repeat = "Y";

            while (repeat == "Y")
            {
                int num = GetNumber("Please enter an integer value: ");
                Console.WriteLine("Number\t\tSquared\t\tCubed\r\n========\t========\t========");
                for (int i = 1; i <= num; i++)
                {
                    Console.Write("{0}\t\t{1}\t\t{2}\r\n", i, i * i, Math.Pow(i, 3));
                }
                repeat = TryAgain("Would you like to continue? (Y or N): ");
            }
        }

        private static int GetNumber(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int number);
            if (!success)
            {
                Console.Write("Invalid input. ");
                return GetNumber(message);
            }
            return number;
        }

        private static string TryAgain(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToUpper();
            if (input == "Y" || input == "N")
            {
                return input;
            }
            else
            {
                Console.Write("Invalid input. ");
                return TryAgain(message);
            }
        }
    }
}

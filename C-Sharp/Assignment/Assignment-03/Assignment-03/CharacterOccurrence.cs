using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    class CharacterOccurrence
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            Console.Write("Enter the letter to count: ");
            char letter = Console.ReadLine()[0];

            int count = CountOccurrences(inputString, letter);
            Console.WriteLine($"The letter '{letter}' appears {count} times in the string.");
            Console.Read();
        }

        static int CountOccurrences(string inputString, char letter)
        {
            int count = 0;
            foreach (char c in inputString)
            {
                if (char.ToUpper(c) == char.ToUpper(letter))
                {
                    count++;
                }
            }
            return count;

        }

    }
}
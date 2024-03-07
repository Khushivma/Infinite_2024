﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_01
{
    class RemoveCharacter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string value");
            String i = Console.ReadLine();
            Console.WriteLine("enter the position");
            int p = Convert.ToInt32(Console.ReadLine());
            String res = RemoveCharacterAtPosition(i, p);
            Console.WriteLine($"{res}");
            Console.Read();


            string RemoveCharacterAtPosition(string input, int position)
            {
                if (position >= 0 && position < input.Length)
                {
                    return input.Remove(position, 1);
                }
                else
                {
                    Console.WriteLine("Invalid position. Character not removed.");
                    return input;
                }


            }
        }
    }
}


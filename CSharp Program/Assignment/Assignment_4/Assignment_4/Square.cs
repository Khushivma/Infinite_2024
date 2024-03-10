using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Square
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.Write("Enter the size of list to add elements: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i} element: ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            Squares(list);
            Console.ReadKey();
        }
        public static void Squares(List<int> list)
        {
            List<int> nlist = new List<int>();//object for list
            nlist.AddRange(list.Select(n => n * n).Where(sq => sq > 20));

            foreach (var res in nlist)
            {
                Console.Write(res + " ");
            }

        }
    }
}

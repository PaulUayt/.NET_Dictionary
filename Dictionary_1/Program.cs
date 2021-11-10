using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Map<int, string>();

            dict.Add(new Item<int, string>(1, "One"));
            dict.Add(new Item<int, string>(1, "One"));
            dict.Add(new Item<int, string>(2, "Two"));
            dict.Add(new Item<int, string>(3, "Three"));
            dict.Add(new Item<int, string>(4, "Four"));
            dict.Add(new Item<int, string>(5, "Five"));
            dict.Add(new Item<int, string>(101, "One hundred one"));

            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(dict.Search(7) ?? "Not find");
            Console.WriteLine(dict.Search(3) ?? "Not find");

            dict.Remove(7);
            dict.Remove(3);
            dict.Remove(1);
            dict.Remove(101);

            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

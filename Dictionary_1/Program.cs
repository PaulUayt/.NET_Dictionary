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
            /*var easyMap = new EasyMap<int, string>();
            easyMap.Add(new Item<int, string>(1, "One"));
            easyMap.Add(new Item<int, string>(2, "Two"));
            easyMap.Add(new Item<int, string>(3, "Three"));
            easyMap.Add(new Item<int, string>(4, "Four"));
            easyMap.Add(new Item<int, string>(5, "Five")); 

            foreach(var item in easyMap)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(easyMap.Search(7) ?? "Not find");
            Console.WriteLine(easyMap.Search(3) ?? "Not find");

            easyMap.Remove(3);
            easyMap.Remove(1);

            foreach (var item in easyMap)
            {
                Console.WriteLine(item);
            }*/


            var dict = new Map<int, string>();
            dict.Add(new Item<int, string>(1, "One"));
            dict.Add(new Item<int, string>(2, "Two"));
            dict.Add(new Item<int, string>(3, "Three"));
            dict.Add(new Item<int, string>(4, "Four"));
            dict.Add(new Item<int, string>(5, "Five"));

            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(dict.Search(7) ?? "Not find");
            Console.WriteLine(dict.Search(3) ?? "Not find");

            dict.Remove(3);
            dict.Remove(1);

            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

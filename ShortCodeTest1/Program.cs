using System;
using System.Collections;
using System.Linq;

namespace ShortCodeTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var enumerable = Range(1, 100);

            //foreach(var i in enumerable)
            //{
            //    Console.WriteLine(i);
            //}

            var list = new Listify(100, 200);

            Console.WriteLine(list[50]);

            foreach(var i in list)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        public static IEnumerable Range(int begin, int end)
        {
            for (int i = begin; i <= end; i++)
            {
                yield return i;
            }
        }
    }
}

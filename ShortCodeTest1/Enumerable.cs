using System;
using System.Collections.Generic;
using System.Text;

namespace ShortCodeTest1
{
    public static class Enumerable
    {
        public static IEnumerable<int> Range(int begin, int end)
        {
            for (int i = begin; i <= end; i++)
                yield return i;
        }
    }
}

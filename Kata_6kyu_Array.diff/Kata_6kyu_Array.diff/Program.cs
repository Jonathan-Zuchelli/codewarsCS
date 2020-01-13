using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_6kyu_Array.diff
{
    public class Kata
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(n => !b.Contains(n)).ToArray();
        }
    }
}

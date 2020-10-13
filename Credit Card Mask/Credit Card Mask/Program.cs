using System;
using System.Linq;

namespace Credit_Card_Mask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maskify("111111111"));
            Console.ReadLine();
        }
        public static string Maskify(string cc)
        {
            if (cc.Length < 4)
            {
                return cc;
            }
            return (String.Concat(Enumerable.Repeat("#", cc.Length - 4))) + cc.Substring(cc.Length - 4);
        }
    }
}

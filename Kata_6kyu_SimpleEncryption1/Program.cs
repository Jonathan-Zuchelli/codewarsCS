using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_6kyu_SimpleEncryption1
{
    public class Kata
    {
        public static string Encrypt(string text, int n)
        {
            if (string.IsNullOrWhiteSpace(text) || n <= 0)
            {
                return text;
            }

            while (n != 0)
            {
                text = string.Concat(text.Where((c, i) => i % 2 == 1).Concat(text.Where((c, i) => i % 2 == 0)));

                n--;
            }

            return text;
        }

        public static string Decrypt(string text, int n)
        {
            if (string.IsNullOrWhiteSpace(text) || n <= 0)
            {
                return text;
            }

            while (n != 0)
            {
                string leftPart = string.Concat(text.Take(text.Length / 2));
                string rightPart = string.Concat(text.Skip(text.Length / 2));

                text = string.Concat(Enumerable.Range(0, text.Length).Select(i => i % 2 == 0 ? rightPart[i / 2] : leftPart[i / 2]));

                n--;
            }

            return text;
        }
    }
}

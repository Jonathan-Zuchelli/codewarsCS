using System;
using System.Linq;

public class Kata
{
    public static string DuplicateEncode(string word)
    {
        return String.Concat((word.ToLower()).Select(x => word.Where(y => x == y).Count() > 1 ? ')' : '('));
    }
}
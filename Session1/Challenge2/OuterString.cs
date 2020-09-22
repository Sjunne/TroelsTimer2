using System;

namespace Challenge2
{
    public class OuterString
    {
        public string ReturnMixedString(string a, string b)
        {
            if(a.Length != 4)
                throw new Exception("første string skal være 4 lang");

            char c = a[0];
            string ab = $"{c}{a[1]}{b}{a[2]}{a[3]}";

            return ab;
        }
    }
}
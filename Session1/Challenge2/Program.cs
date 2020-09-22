using System;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
          var test = new OuterString();
          Console.WriteLine(test.ReturnMixedString("<<>>", "test"));
        }
    }
}
using System;

namespace MathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator test = new Calculator();
            test.Add(2, 2);
            test.Add(new int[] {1, 2, 3});
            test.TwoInts();
        }
    }
}
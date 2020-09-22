using System;

namespace MathLib
{
    public class Calculator
    {

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return sum;
        }

        public void TwoInts()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x + y);
        }
    }
}
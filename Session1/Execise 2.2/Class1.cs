using System;

namespace Exercice2
{
    public class Class1
    {
        public void NumberPrinter(int x)
        {
            for (int i = 0; i < x; i++)
            {
                if(i%2 == 0)
                    Console.WriteLine(i);
            }
        }
        
        public void NumberPrinterOdd(int x)
        {
            for (int i = 0; i < x; i++)
            {
                if(i%2 != 0)
                    Console.WriteLine(i);
            }
        }
        
        public void NumberPrinterXAndY(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                if(i%y==0)
                    Console.WriteLine(i);
            }
        }
    }
}     
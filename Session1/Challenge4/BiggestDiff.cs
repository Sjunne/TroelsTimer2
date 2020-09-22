namespace Challenge4
{
    public class BiggestDiff
    {
        public int BiggestDiffOfArray(int[] a)
        {
            int largest = 0;
            int smallest = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (i > largest)
                    largest = i;
                if (i < smallest)
                    smallest = i;
            }

            return largest - smallest;
        }
    }
}
namespace Challenge5
{
    public class ArrayClumb
    {
        public int ArrayClumbMethod(int[] a)
        {
            int numberOfClumbs = 0;
            int currentClumb = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i != a.Length-1)
                {
                    if (a[i] == a[i + 1] && currentClumb != a[i])
                    {
                        currentClumb = a[i];
                        numberOfClumbs++;
                    }
                    else if(currentClumb != a[i+1])
                    {
                        currentClumb = 0;
                    }
                        
                }
            }

            return numberOfClumbs;
        }
    }
}
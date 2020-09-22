namespace Challenge3
{
    public class SubString
    {
        public string Substringer(string a, int b)
        {
            string ab = $"{a.Substring(0, b)}{a.Substring(a.Length - 2)}";
            return ab;
        }
    }
}
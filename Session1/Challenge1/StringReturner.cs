namespace Challenge1
{
    public class StringReturner
    {
        public string StringReturnerMethod(string a, string b)
        {
            string ab = $"{a}{b}{b}{a}";
            return ab;
        }
    }
}
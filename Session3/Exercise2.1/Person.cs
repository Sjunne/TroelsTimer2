namespace Exercise1
{
    public class Person
    {
        public override string ToString()
        {
            return $"{nameof(firstName)}: {firstName}, {nameof(lastName)}: {lastName}, {nameof(age)}: {age}, {nameof(height)}: {height}, {nameof(isMarried)}: {isMarried}, {nameof(sex)}: {sex}, {nameof(hobbies)}: {hobbies}";
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public double height { get; set; }
        public bool isMarried { get; set; }
        public char sex { get; set; }
        public string[] hobbies { get; set; }
        
        
    }
}
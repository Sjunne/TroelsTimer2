using System;
using System.Collections.Generic;

namespace Exercise5
{
    public class Bird
    {
        private readonly string flap = "bird Flaps Wings";
        private readonly string fly = "bird flies";
        private readonly string sing = "bird sings";
        public Action<string> birdStuff;

        public void doStuff()
        {
            List<string> list = new List<string>(){flap,fly,sing};
            Random rnd = new Random();
            
            
            for (int i = 0; i < 20; i++)
            {
                var format = list[rnd.Next(list.Count)];
                Console.WriteLine(format);
                birdStuff?.Invoke(format);
            }
        }
    }
}
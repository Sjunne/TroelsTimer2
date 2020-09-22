using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person one = new Person()
            {
                age = 18,
                firstName = "Mattias",
                height = 180,
                hobbies = new[] {"fodbold", "håndbold"},
                isMarried = true,
                lastName = "Leth",
                sex = 'M',
            };
            Person two = new Person()
            {
                age = 19,
                firstName = "Mattias2",
                height = 180,
                hobbies = new[] {"fodbold", "håndbold"},
                isMarried = true,
                lastName = "Leth",
                sex = 'M',
            };
            Person three = new Person()
            {
                age = 20,
                firstName = "Mattias3",
                height = 180,
                hobbies = new[] {"fodbold", "håndbold"},
                isMarried = true,
                lastName = "Leth",
                sex = 'M',
            };
            
            List<Person> list = new List<Person> {one, two, three};


            string jsonFormatted = JsonSerializer.Serialize(list, new JsonSerializerOptions()
            {
                WriteIndented = true
            });
            
            Console.WriteLine(jsonFormatted);
        }

    }
}
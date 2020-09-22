using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using Exercise1;

namespace Exercise2._1
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
            storeObjects(list);
            List<Person> test = readObjects();
        }

        public static void storeObjects(List<Person> persons)
        {
            string jsonFormatted = JsonSerializer.Serialize(persons);

            using (StreamWriter file = new StreamWriter("My Persons"))
            {
                file.WriteLine(jsonFormatted);
            }
        }

        public static List<Person> readObjects()
        {
            StringBuilder sb = new StringBuilder();
            List<Person> myJson = new List<Person>();
            using (StreamReader sr = new StreamReader("My Persons"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    myJson = JsonSerializer.Deserialize<List<Person>>(line);
                }

                for (int i = 0; i < myJson.Count; i++)
                {
                    Console.Write(myJson[i]);
                }
            }

            sb.ToString();
            return myJson;
        }
    }
}
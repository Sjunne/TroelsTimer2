using System;
using System.Collections.Generic;
using Models;

namespace FileData
{
    public class FileAdapter : IfileContext
    {
        private readonly FileContext FileContext = new FileContext();
        
        public void AddAdult(Adult adult)
        {
            var fileContextAdults = FileContext.Adults;
            fileContextAdults.Add(adult);
            Console.WriteLine(fileContextAdults);
            FileContext.SaveChanges();
        }

        public IList<Adult> getAllAdults()
        {
            return FileContext.Adults;
        }

        public IList<Family> getAllFamilies()
        {
            return FileContext.Families;
        }
    }
}
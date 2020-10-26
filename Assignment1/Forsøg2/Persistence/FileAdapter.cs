using System;
using System.Collections.Generic;
using Forsøg2.Models;
using Models;

namespace FileData
{
    public class FileAdapter
    {
        private readonly FileContext FileContext = new FileContext();
        
        public void AddAdult(Adult adult)
        {
            var fileContextAdults = FileContext.Adults;
            fileContextAdults.Add(adult);
            FileContext.SaveChanges();
        }

        public void AddFamily(Family family)
        {
            FileContext.Families.Add(family);
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
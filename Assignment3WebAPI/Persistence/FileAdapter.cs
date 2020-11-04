using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3WebAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3WebAPI.Persistence
{
    public class FileAdapter : IfileContext
    {
        private readonly FileContext FileContext = new FileContext();
        
        public async Task<Adult> AddAdult(Adult adult)
        {
            Console.WriteLine("Add");
            int max = FileContext.Adults.Max(a => a.Id);
            adult.Id = (++max);
            FileContext.Adults.Add(adult);
            FileContext.SaveChanges();
            return adult;
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

        public async Task<Adult> getAdult(int id)
        {
            return FileContext.Adults[id];
        }

        public async Task<IList<Adult>> getAllAdults(string sex, string firstName, string lastName, string eyeColour,
            string hairColor, int? height,
            float? weight, int? id, string jobTitle, int? age)
        {
            IList<Adult> tmp = new List<Adult>(FileContext.Adults.Where(adult =>
                (sex != null && sex == adult.Sex || sex == null)
                && (id != null && id == adult.Id || id == null)
                && (firstName != null && firstName.Equals(adult.FirstName) || firstName == null)
                && (lastName != null && lastName.Equals(adult.LastName) || lastName == null)
                && (eyeColour != null && eyeColour.Equals(adult.EyeColor) || eyeColour == null)
                && (hairColor != null && hairColor.Equals(adult.HairColor) || hairColor == null)
                && (height != null && height == adult.Height || height == null)
                && (weight != null && weight == adult.Weight || weight == null)
                && (jobTitle != null && jobTitle.Equals(adult.JobTitle) || jobTitle == null)
                && (age != null && age == adult.Age || age == null)
                ));
            return tmp;
        }

        public async Task removeAdult(int id)
        {
            Console.WriteLine(id);
           FileContext.Adults.RemoveAt(id);
           FileContext.SaveChanges();        }
    }
}
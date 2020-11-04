using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment3WebAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3WebAPI.Persistence
{
    public interface IfileContext
    {
        Task<Adult> AddAdult(Adult adult);
        void AddFamily(Family family);

        IList<Adult> getAllAdults();
        IList<Family> getAllFamilies();
        Task<Adult> getAdult(int id);
        Task<IList<Adult>> getAllAdults(string sex, string firstName, string lastName, string eyeColour,
            string hairColor, int? height, float? weight, int? id, string jobTitle, int? age);

        Task removeAdult(int id);
    }
}
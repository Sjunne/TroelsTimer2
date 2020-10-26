using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment3WebAPI.Data;

namespace Assignment3WebAPI.Persistence
{
    public interface IfileContext
    {
        Task<Adult> AddAdult(Adult adult);
        void AddFamily(Family family);

        IList<Adult> getAllAdults();
        IList<Family> getAllFamilies();
        Task<IList<Adult>> getAllAdults(string sex, string firstName, string lastName, string eyeColour,
            string hairColor, int? height, float? weight, int? id, string jobTitle, int? age);
    }
}
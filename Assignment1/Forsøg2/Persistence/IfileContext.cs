using System.Collections.Generic;
using System.Threading.Tasks;
using Forsøg2.Models;
using Models;

namespace FileData
{
    public interface IfileContext
    {
        Task AddAdult(Adult adult);
        void AddFamily(Family family);

        Task<IList<Adult>> getAllAdults(string query);
        IList<Family> getAllFamilies();

        Task RemoveAdult(int id);
    }
}
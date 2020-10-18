using System.Collections.Generic;
using Forsøg2.Models;
using Models;

namespace FileData
{
    public interface IfileContext
    {
        void AddAdult(Adult adult);
        void AddFamily(Family family);

        IList<Adult> getAllAdults();
        IList<Family> getAllFamilies();
    }
}
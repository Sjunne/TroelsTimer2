using System.Collections.Generic;
using Models;

namespace FileData
{
    public interface IfileContext
    {
        void AddAdult(Adult adult);

        IList<Adult> getAllAdults();
        IList<Family> getAllFamilies();
    }
}
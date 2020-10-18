using Forsøg2.Models;
using Models;

namespace ModelsAddFamily
{
    public class AddFamilyHolder
    {
        public Family family { get; set; }

        public AddFamilyHolder()
        {
            family = new Family();
        }
    }
}
using System.Collections.Generic;
using Models;

namespace Forsøg2.Models {
public class Child : Person {
    
    public List<ChildInterest> ChildInterests { get; set; }
    public List<Pet> Pets { get; set; }

    public Child()
    {
        Pets = new List<Pet>();
        ChildInterests = new List<ChildInterest>();
    }
    public void Update(Child toUpdate) {
        base.Update(toUpdate);
        ChildInterests = toUpdate.ChildInterests;
        Pets = toUpdate.Pets;
    }

}
}
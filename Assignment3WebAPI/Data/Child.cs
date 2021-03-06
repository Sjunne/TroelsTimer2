using System.Collections.Generic;

namespace Assignment3WebAPI.Data {
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
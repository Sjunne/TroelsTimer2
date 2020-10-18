using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Models;

namespace Forsøg2.Models {
public class Family {
    
    //public int Id { get; set; }
    [Required]
    public string StreetName { get; set; }
    [Required]
    public int HouseNumber{ get; set; }
    public List<Adult> Adults { get; set; }
    public List<Child> Children{ get; set; }
    public List<Pet> Pets{ get; set; }

    public Family() {
        Adults = new List<Adult>();  
        Children = new List<Child>();
        Pets = new List<Pet>();
    }

}


}
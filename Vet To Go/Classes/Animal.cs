using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet_To_Go.Classes
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public int OwnerID { get; set; }
        public int SpeciesID { get; set; }

        public String AnimalName { get; set; }
        public String Species { get; set; }
        public String Breed { get; set; }
        public String Color { get; set; }
        public String ShelterOrBreeder { get; set; }
        public String Weight { get; set; }
        public Boolean IsMale { get; set; }
        public Boolean IsLicensed { get; set; }
        public Boolean IsSterilized { get; set; }


        public Animal()
        {

        }

        public Animal(int ownerID, String name, String species)
        {
            this.OwnerID = ownerID;
            this.AnimalName = name;
            this.Species = species;
        }
    }
}

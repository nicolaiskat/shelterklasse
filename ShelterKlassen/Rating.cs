using System;
namespace ShelterKlassen
{
    public class Rating
    {
        public int ID;
        public int Raiting;
        public Shelter Shelter;
        public string Description;
        public Bruger Bruger;

        private static int IDNumberSeed = 1;

        public Rating(int Raiting, Shelter Shelter, Bruger Bruger, string Description = "")
        {
            this.ID = IDNumberSeed;
            IDNumberSeed++;

            this.Raiting = Raiting;
            this.Shelter = Shelter;
            this.Description = Description;
            this.Bruger = Bruger;
        }
        public int getID()
        {
            return this.ID;
        }
        public int getRaiting()
        {
            return this.Raiting;
        }
        public Shelter getShelter()
        {
            return this.Shelter;
        }
        public string getDescription()
        {
            return this.Description;
        }
        public Bruger getBruger()
        {
            return this.Bruger;
        }
    }
}

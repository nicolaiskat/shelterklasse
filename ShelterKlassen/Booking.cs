using System;
namespace ShelterKlassen
{
    public class Booking
    {
        public int ID;
        public DateTime StartDato;
        public DateTime SlutDato;
        public int AntalPersoner;
        public Shelter Shelter;
        public Bruger Bruger;
        public string Description;

        static private int IDNumberSeed = 1;

        public Booking(DateTime Start, DateTime Slut, int AntalPersoner, Shelter Shelter, Bruger Bruger, string Description = "")
        {
            this.ID = IDNumberSeed;
            IDNumberSeed++;

            this.StartDato = Start;
            this.SlutDato = Slut;
            this.AntalPersoner = AntalPersoner;
            this.Shelter = Shelter;
            this.Bruger = Bruger;
            this.Description = Description;

        }
        public int getID()
        {
            return this.ID;
        }
        public DateTime getStartDate()
        {
            return this.StartDato;
        }
        public DateTime getSlutDate()
        {
            return this.SlutDato;
        }
        public int getAntalPersoner()
        {
            return this.AntalPersoner;
        }
        public Shelter GetShelter()
        {
            return this.Shelter;
        }
        public Bruger getBruger()
        {
            return this.Bruger;
        }
        public string getDescription()
        {
            return this.Description;
        }
    }
}

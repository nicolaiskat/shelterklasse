using System;
using System.Collections.Generic;

namespace ShelterKlassen
{
    public class Lokalitet
    {
        public int ID;
        public string Adresse;
        public string Description;
        public int Mobil;
        public string Navn;
        public Kontaktperson Kontaktperson;

        public List<Shelter> Shelters = new List<Shelter>();

        static private int IDNumberSeed = 1;

        public Lokalitet(int Mobil, string Adresse, string Navn, Kontaktperson kontaktperson, string Description = "")
        {
            this.ID = IDNumberSeed;
            IDNumberSeed++;
            
            this.Adresse = Adresse;
            this.Description = Description;
            this.Navn = Navn;
            this.Mobil = Mobil;
            this.Kontaktperson = kontaktperson;
        }
        public int getID()
        {
            return this.ID;
        }
        public string getAdresse()
        {
            return this.Adresse;
        }
        public string getDescription()
        {
            return this.Description;
        }
        public int getMobil()
        {
            return this.Mobil;
        }
        public string getName()
        {
            return this.Navn;
        }
        public List<Shelter> getShelters()
        {
            return this.Shelters;
        }
        public Kontaktperson getKontaktperson()
        {
            return this.Kontaktperson;
        }
        public void addShelter(Shelter shelter)
        {
            this.Shelters.Add(shelter);
        }


    }
}

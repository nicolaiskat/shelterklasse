using System;
using System.Collections.Generic;

namespace ShelterKlassen
{
    public class Kommune
    {
        public int ID;
        public string Navn;
        public string Adresse;
        public List<Kontaktperson> Kontaktpersoner = new List<Kontaktperson>();

        static private int IDNumberSeed = 1;

        public Kommune(string Navn, string Adresse, Kontaktperson Kontaktperson)
        {
            this.ID = IDNumberSeed;
            IDNumberSeed++;

            this.Navn = Navn;
            this.Adresse = Adresse;
            this.Kontaktpersoner.Add(Kontaktperson);
        }
        public int getID()
        {
            return this.ID;
        }
        public string getName()
        {
            return this.Navn;
        }
        public string getAdresse()
        {
            return this.Adresse;
        }
        public void addKontaktperson(Kontaktperson kontaktperson)
        {
            this.Kontaktpersoner.Add(kontaktperson);
        }
        public List<Kontaktperson> getKontaktPersoner()
        {
            return this.Kontaktpersoner;
        }
    }
}

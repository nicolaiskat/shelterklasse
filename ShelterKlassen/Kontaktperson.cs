using System;
using System.Collections.Generic;


namespace ShelterKlassen
{
    public class Kontaktperson : Person
    {
        public int ID;
        public Kommune Kommune;
        public List<Lokalitet> Lokaliteter = new List<Lokalitet>();

        static private int BrugerIDSeed = 1;
        public Kontaktperson(string navn, string email, int mobil, string adresse, Lokalitet lokalitet) : base(navn, email, mobil, adresse)
        {
            this.ID = BrugerIDSeed;
            BrugerIDSeed++;
            this.Lokaliteter.Add(lokalitet);
        }
        public int getBrugerID()
        {
            return this.ID;
        }
        public Kommune getKommune()
        {
            return this.Kommune;
        }
        public List<Lokalitet> getLokaliteter()
        {
            return this.Lokaliteter;
        }
        public void addLokalitet(Lokalitet lokalitet)
        {
            Lokaliteter.Add(lokalitet);
        }
    }
}

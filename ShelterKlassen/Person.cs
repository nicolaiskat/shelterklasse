using System;
namespace ShelterKlassen
{
    public class Person
    {
        public string Navn;
        public string Email;
        public int Mobil;
        public string Adresse;

        public Person(string navn, string email, int mobil, string adresse)
        {
            this.Navn = navn;
            this.Email = email;
            this.Mobil = mobil;
            this.Adresse = adresse;
        }
        public string getName()
        {
            return this.Navn;
        }
        public string getAdress()
        {
            return this.Adresse;
        }
        public int getNumber()
        {
            return this.Mobil;
        }
        public string getEmail()
        {
            return this.Email;
        }
    }
}

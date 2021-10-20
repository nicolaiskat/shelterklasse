using System;
using System.Collections.Generic;


namespace ShelterKlassen
{
    public class Bruger : Person
    {
        public int BrugerID;

        public List<Booking> Bookings = new List<Booking>();

        static private int BrugerIDSeed = 1;
        public Bruger(string navn, string email, int mobil, string adresse) : base(navn, email, mobil, adresse)
        {
            this.BrugerID = BrugerIDSeed;
            BrugerIDSeed++;
        }
        public int getBrugerID()
        {
            return this.BrugerID;
        }
        public List<Booking> getBookings()
        {
            return this.Bookings;
        }
        public void addBooking(Booking booking)
        {
            this.Bookings.Add(booking);
            Shelter.Bookings.Add(booking);
        }
        
    }
}

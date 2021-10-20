using System;
using System.Collections.Generic;

namespace ShelterKlassen
{
    public class Shelter
    {
        public int ShelterID;
        public Boolean BookingTilladt { get; set; }
        public Int16 MaksPersoner;
        public Int16 Kvm;
        public string Beskrivelse;

        //1
        public Lokalitet Lokalitet;

        //0..*
        public List<Rating> Ratings = new List<Rating>();
        static public List<Booking> Bookings = new List<Booking>();
        public double Rating { get
            {
                return getAvgRating();
            }
        }

        private static int IDNumberSeed = 1;

        public Shelter(Int16 MaksPersoner, Int16 Kvm, Lokalitet Lokalitet, Boolean BookingTilladt = true, string Beskrivelse = "")
        {
            this.ShelterID = IDNumberSeed;
            IDNumberSeed++;

            this.BookingTilladt = BookingTilladt;
            this.MaksPersoner = MaksPersoner;
            this.Kvm = Kvm;
            this.Beskrivelse = Beskrivelse;
            this.Lokalitet = Lokalitet;
        }

        public int getShelterID()
        {
            return this.ShelterID;
        }
        public Int16 getMaksPersoner()
        {
            return this.MaksPersoner;
        }
        public Int16 getKvm()
        {
            return this.Kvm;
        }
        public Lokalitet getLokalitet()
        {
            return this.Lokalitet;
        }
        public Boolean getBookingTilladt()
        {
            return this.BookingTilladt;
        }
        public string getBeskrivelse()
        {
            return this.Beskrivelse;
        }
        public double getAvgRating()
        {
            double sum = 0;
            foreach (var item in Ratings)
            {
                sum += item.Raiting;
            }
            double AvgRating = sum / Ratings.Count;
            return AvgRating;
        }
        public List<Rating> getRatings()
        {
            return this.Ratings;
        }
        public List<Booking> getBookings()
        {
            return Bookings;
        }

    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace CarRental_RestAPI.Models
{
    public partial class Car
    {
        public Car()
        {
            Rentals = new HashSet<Rental>();
        }

        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public int KmDriven { get; set; }
        public int ColorId { get; set; }
        public byte NumberOfSeats { get; set; }
        public string LicenseNo { get; set; }
        public bool Active { get; set; }
        public string FuelType { get; set; }

        public virtual Color Color { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}

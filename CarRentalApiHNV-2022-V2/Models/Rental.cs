using System;
using System.Collections.Generic;

#nullable disable

namespace CarRental_RestAPI.Models
{
    public partial class Rental
    {
        public int RentalId { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DeliverDate { get; set; }
        public int KmStart { get; set; }
        public int? KmEnd { get; set; }
        public double Price { get; set; }
        public string Comment { get; set; }

        public virtual Car Car { get; set; }
        public virtual Customer Customer { get; set; }
    }
}

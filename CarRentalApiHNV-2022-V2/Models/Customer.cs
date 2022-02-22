using System;
using System.Collections.Generic;

#nullable disable

namespace CarRental_RestAPI.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Rentals = new HashSet<Rental>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DrivingLicenseNo { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
    }
}

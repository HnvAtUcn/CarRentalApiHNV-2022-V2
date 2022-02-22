using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRental_RestAPI.Models;

namespace CarRental_RestAPI.Data
{
    public class CarRental_RestAPIContext : DbContext
    {
        public CarRental_RestAPIContext(DbContextOptions<CarRental_RestAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CarRental_RestAPI.Models.Color> Color { get; set; }

        public DbSet<CarRental_RestAPI.Models.Customer> Customer { get; set; }

        public DbSet<CarRental_RestAPI.Models.Car> Car { get; set; }

        public DbSet<CarRental_RestAPI.Models.Rental> Rental { get; set; }
    }
}

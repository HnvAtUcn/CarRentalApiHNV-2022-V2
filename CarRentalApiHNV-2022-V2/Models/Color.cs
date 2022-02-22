using System;
using System.Collections.Generic;

#nullable disable

namespace CarRental_RestAPI.Models
{
    public partial class Color
    {
        public Color()
        {
            Cars = new HashSet<Car>();
        }

        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public string ColorDescription { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using odetofood.DL.Models;

namespace odetofood.DL
{
    public class RestaurantDbContext: DbContext
    {
        public RestaurantDbContext()
            : base("DefaultConnection")
        {}

          DbSet<Restaurant> Restaurants { get; set; }
          DbSet<RestaurantReview> RestaurantsReviews { get; set; }
    }
}

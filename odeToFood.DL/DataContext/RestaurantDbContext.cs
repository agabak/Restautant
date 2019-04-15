using odeToFood.DL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odeToFood.DL.DataContext
{
    public class RestaurantDbContext: DbContext
    {
        public RestaurantDbContext(): base("DefaultConnection"){}

        DbSet<Restaurant> Restaurants { get; set; }
        DbSet<RestaurantReview> Reviews { get; set; }
    }
}
 
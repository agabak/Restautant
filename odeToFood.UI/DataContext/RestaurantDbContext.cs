using odeToFood.DL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace odeToFood.UI.DataContext
{
    public class RestaurantDbContext: DbContext
    {
        public RestaurantDbContext(): base("DefaultConnection"){}

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }
    }
}
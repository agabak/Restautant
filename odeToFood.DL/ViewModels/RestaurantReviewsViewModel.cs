using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odeToFood.DL.ViewModels
{
    public class RestaurantReviewsViewModel
    {
        public string RestaurantName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Rating { get; set; }
        public string RateDescription { get; set; }
    }
}

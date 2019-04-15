using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odeToFood.DL.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
    }
}

namespace odeToFood.UI.Migrations
{
    using odeToFood.DL.Models;
    using odeToFood.UI.DataContext;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RestaurantDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RestaurantDbContext context)
        {
            //var restaurants = new List<Restaurant>
            //{
            //    new Restaurant{ Name ="Panera Bread", City ="Houston", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 3, Description ="Pretty good place" }

            //    }},

            //     new Restaurant{ Name ="Chili's Grill & Bar", City ="Des Moines", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 8, Description ="New Orleans-style eatery & bar with hearty entrees, Sunday brunch with live jazz & festive ambiance." }

            //    }},

            //     new Restaurant{ Name ="The Rouxpour Restaurant & Bar - Sugar Land", City ="Houston", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 6, Description ="Pretty good place" }

            //    }},

            //     new Restaurant{ Name ="Churrascos Sugar Land", City ="Kansa City", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 9, Description ="Upscale South American steakhouse offering prime cuts, pisco sours & other drinks in a luxe setting." }

            //    }},

            //     new Restaurant{ Name ="Fish City Grill", City ="Boston", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 3, Description ="Easygoing chain outpost dishing up Southern-style seafood such as signature oyster nachos." }

            //    }},
            //     new Restaurant{ Name ="Antonia's Italian Ristorante", City ="Sugar Land", Country ="Canada", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 4, Description ="Risotto, rice, pizza, pasta, seafood & meats round out the menu at this classic Italian restaurant." }

            //    }},
            //     new Restaurant{ Name ="Japaneiro's", City ="Memphins", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 8, Description ="Inventive Japanese-Latin eats including fusion sushi rolls & margaritas served in a bustling space." }

            //    }},
            //     new Restaurant{ Name ="Thai Cottage - Sugar Land", City ="Sugar Land", Country ="Canada", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 10, Description ="Laid-back chain serving familiar Thai dishes from mild to spicy, with gluten-free & vegan options." }

            //    }},
            //     new Restaurant{ Name ="Black Walnut Cafe", City ="Houston", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 10, Description ="Branch of a warm, casual chain offering American fare for breakfast, lunch & dinner & a full bar." }

            //    }},
            //     new Restaurant{ Name ="Fadi’s Mediterranean Grill", City ="Houston", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 7, Description ="Traditional fare from tabbouleh to stuffed whole lamb dished up in warm, welcoming environs." }

            //    }},
            //     new Restaurant{ Name ="Turquoise Grill & Bar", City ="New York", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 10 ,Description ="This modern outpost with a long menu of Mediterranean classics offers cocktails & an outdoor patio." }

            //    }},
            //     new Restaurant{ Name ="Guru Burgers Crepes", City ="Houston", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 5, Description ="Modern, airy eatery creating innovative burgers & crêpes from organic, locally sourced ingredients." }

            //    }},
            //     new Restaurant{ Name ="Grimaldi's Pizzeria", City ="Chicago", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 10, Description ="Casual, Brooklyn-based pizzeria chain serving brick-oven pies & calzones plus wine & beer." }

            //    }},
            //     new Restaurant{ Name ="Zoës Kitchen", City ="Houston", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 3, Description ="Pretty good place" }

            //    }},
            //     new Restaurant{ Name ="BJ's Restaurant & Brewhouse", City ="Chicago", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 10, Description ="Family-friendly chain outpost pairs familiar pub fare with an extensive list of house brews." }

            //    }},
            //     new Restaurant{ Name ="Flying Saucer", City ="New York", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 8, Description ="Chain taproom offering 200+ global beers & American pub fare in tavernlike surroundings." }

            //    }},
            //     new Restaurant{ Name ="bellagreen", City ="Washington Dc", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 3, Description ="Health-conscious spot with a wide variety of vegan, vegetarian & gluten-free menu items." }

            //    }},
            //     new Restaurant{ Name ="P.F. Chang's", City ="Des Moines", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 3, Description ="Family-friendly chain offering creative takes on Chinese fare in a striking space." }

            //    }},
            //     new Restaurant{ Name ="MOD Pizza", City ="Sugar Land", Country ="Canada", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 3, Description ="Counter-serve chain with industrial-chic decor firing up build-your-own pizza in wood-burning ovens." }

            //    }}, new Restaurant{ Name ="Pho Ben Noodle House", City ="New York", Country ="USA", Reviews = new List<RestaurantReview> 
            //    {
            //        new RestaurantReview { Rating = 3, Description ="Sleek Vietnamese choice for soups & standards in a refined space with a glowing bar & bamboo." }

            //    }}
            //};
            ////  This method will be called after migrating to the latest version.
            //context.Restaurants.AddRange(restaurants);
            //context.SaveChanges();

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}

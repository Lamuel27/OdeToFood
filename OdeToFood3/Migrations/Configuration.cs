namespace OdeToFood3.Migrations
{
    using OdeToFood3.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood3.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OdeToFood3.Models.OdeToFoodDb";
        }

        protected override void Seed(OdeToFood3.Models.OdeToFoodDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant { Name = "Sabantino's", City = "Baltimore", Country = "USA" },
                new Restaurant { Name = "Great Lake", City = "Superior", Country = "USA" },
                new Restaurant
                {
                    Name = "Smaka",
                    City = "Gothesburg",
                    Country = "Sweden",
                    Reviews =
                        new List<RestaurantReview> {
                        new RestaurantReview { Rating = 9, Body = "Great food!", ReviewerName = "Lamuel" }
                        }
                });
        }
    }
}


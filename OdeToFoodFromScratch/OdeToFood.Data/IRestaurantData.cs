using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Restaurant 1", Location = "Kumanovo", Cuisine = CuisineType.Indian },

                new Restaurant { Id = 2, Name = "Restaurant 2", Location = "Skopje", Cuisine = CuisineType.Mexican }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants;
        }
    }
}

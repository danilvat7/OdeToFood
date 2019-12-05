using System;
using System.Collections.Generic;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData: IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant> {
                new Restaurant { Id=1, Name="Nika" },
                new Restaurant { Id=2, Name="Druzhba" }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        List<Restaurant> _restaurants;
    }
}

using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();

        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }

        public void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }

        public Dish GetDishByName(string dishName)
        {
            foreach (var dish in dishes)
            {
                if (dishName == dish.Name)
                {
                    return dish;
                }
            }
            return null;
        }
    }
}
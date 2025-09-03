using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private int number;
        public int Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }
        private bool isOccupied;
        public bool IsOccupied
        {
            get
            {
                return this.isOccupied;
            }
            set
            {
                this.isOccupied = value;
            }
        }
        private List<Dish> order = new List<Dish>();

        public Table(int number, bool isOccupied = false)
        {
            this.Number = number;
            this.IsOccupied = isOccupied;
        }
        public void Occupy()
        {
            this.IsOccupied = true;
        }
        public void Free()
        {
            this.IsOccupied = false;
            order.Clear();
        }
        public void AddToOrder(Dish dish)
        {
            order.Add(dish);
        }
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}
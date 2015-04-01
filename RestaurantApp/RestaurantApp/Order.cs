namespace RestaurantApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Order
    {
        private ICollection<string> orderList;

        public Order()
        {
            this.orderList = new List<string>();
        }

        public ICollection<string> OrderList
        {
            get { return new List<string>(this.orderList); }
            set { this.orderList = value; }
        }

        public void AddOrder(int menuItemNumber)
        {
            if (menuItemNumber - 1 < 0 || menuItemNumber - 1 > Menu.MenuList.Count)
            {
                throw new ArgumentOutOfRangeException("Menu item doesn't exist");
            }

            string menuItem = Menu.MenuList.Keys.ElementAt(menuItemNumber - 1);
            this.orderList.Add(menuItem);
        }
    }
}
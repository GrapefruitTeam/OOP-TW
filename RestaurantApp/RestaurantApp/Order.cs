namespace RestaurantApp
{
    using System.Collections.Generic;

    public class Order
    {
        private ICollection<MenuItem> orderList;

        public Order()
        {
            this.orderList = new List<MenuItem>();
        }

        public ICollection<MenuItem> OrderList
        {
            get { return new List<MenuItem>(this.orderList); }
            set { this.orderList = value; }
        }

        public void AddItem(MenuItem item)
        {
            this.orderList.Add(item);
        }

        public void RemoveItem(MenuItem item)
        {
            this.orderList.Remove(item);
        }

        public void RemoveOrder()
        {
            this.orderList.Clear();
        }
    }
}

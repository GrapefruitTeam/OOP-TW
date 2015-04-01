using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Order
    {
        private ICollection<MenuItem> orderList;

        public Order()
        {
            this.orderList = new List<MenuItem>();
        }

        public ICollection<MenuItem> OrderList
        {
            get { return new List<MenuItem>(orderList); }
            set { orderList = value; }
        }

        public void AddItem(MenuItem item)
        {
            this.orderList.Add(item);
        }
    }
}

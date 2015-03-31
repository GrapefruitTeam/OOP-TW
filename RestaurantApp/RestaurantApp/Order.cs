using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Order
    {
        private ICollection<string> orderList;

        public Order()
        {
            this.orderList = new List<string>();
        }

        public ICollection<string> OrderList
        {
            get { return orderList; }
            set { orderList = value; }
        }
    }
}

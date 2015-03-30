using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Waiter : AuthorizedEmployee, IOrder, ICancelOrder
    {
        public Waiter(string name, string employeeId, string password)
            : base(name, employeeId, password)
        {
        }
    }
}

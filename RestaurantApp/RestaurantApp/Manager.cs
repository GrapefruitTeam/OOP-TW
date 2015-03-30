using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Manager : AuthorizedEmployee, IOrder, ICancelOrder, IReserve, ICancelReservation
    {
        public Manager(string name, string employeeId, string password)
            : base(name, employeeId, password)
        {
        }
    }
}

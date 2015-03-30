using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Hostess : AuthorizedEmployee, IReserve, ICancelReservation
    {
        public Hostess(string name, string employeeId, string password)
            : base(name, employeeId, password)
        {
        }
    }
}

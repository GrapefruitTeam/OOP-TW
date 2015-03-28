using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Manager : Employee, IOrder, ICancelOrder, IReserve, ICancelReservation
    {
        
    }
}

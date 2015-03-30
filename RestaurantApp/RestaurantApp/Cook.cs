using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Cook : Employee
    {
        public Cook(string name, string employeeId)
            : base(name, employeeId)
        {
        }
    }
}

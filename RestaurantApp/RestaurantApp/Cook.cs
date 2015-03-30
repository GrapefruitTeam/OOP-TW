using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Cook : Employee
    {
        public Cook(string name, int employeeId)
            : base(name, employeeId)
        {
        }
    }
}

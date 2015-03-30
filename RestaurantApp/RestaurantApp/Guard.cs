using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Guard : Employee
    {
        public Guard(string name, string employeeId)
            : base(name, employeeId)
        {
        }
    }
}

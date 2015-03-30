using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Busser : Employee
    {
        public Busser(string name, int employeeId)
            : base(name, employeeId)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public abstract class Employee : Person
    {
        public Employee(string name, string employeeId)
            : base(name)
        {
            this.EmployeeId = employeeId;
        }

        public string EmployeeId { get; set; }
    }
}

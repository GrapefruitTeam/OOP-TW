using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public abstract class AuthorizedEmployee : Employee
    {
        public AuthorizedEmployee(string name, string employeeId, string password)
            : base(name, employeeId)
        {
            this.Password = password;
        }
        public string Password { get; set; }
    }
}

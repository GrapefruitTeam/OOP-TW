using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Waiter : AuthorizedEmployee, IOrder, ICancelOrder, ICheckable
    {
        public Waiter(string name, string employeeId, string password)
            : base(name, employeeId, password)
        {
        }

        public void AddMenuItemToOrder(Table table, int menuItemNumber)
        {
            table.Order.AddOrder(menuItemNumber);
        }

        public void PrintCheck(Table table)
        {
            decimal sum = 0;
            Console.WriteLine("CHECK:");
            foreach (var item in table.Order.OrderList)
            {
                Console.WriteLine("{0,-20} {1:C}", item, Menu.MenuList[item]);
                sum += (decimal)Menu.MenuList[item];
            }
            Console.WriteLine("Total price: {0,16:C}", sum);
        }
    }
}

namespace RestaurantApp
{
    using System;

    public class Waiter : AuthorizedEmployee, IOrder, ICancelOrder, ICheckable
    {
        public Waiter(string name, string employeeId, string password)
            : base(name, employeeId, password)
        {
        }

        public void AddMenuItemToOrder(Table table, MenuItem item)
        {
            table.Order.AddItem(item);
        }

        public void PrintCheck(Table table)
        {
            decimal sum = 0;
            Console.WriteLine("CHECK:");
            foreach (var item in table.Order.OrderList)
            {
                Console.WriteLine("{0,-20} {1:C}", item.Name, item.Price);
                sum += (decimal)item.Price;
            }

            Console.WriteLine("Total price: {0,16:C}", sum);
        }
    }
}

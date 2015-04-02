namespace RestaurantApp
{
    using System;

    public class Waiter : AuthorizedEmployee, IOrder, ICancelOrder, ICheckable, ICloseTable
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
            Console.WriteLine("CHECK table {0}:", ServingArea.Tables.IndexOf(table) + 1);
            foreach (var item in table.Order.OrderList)
            {
                Console.WriteLine("{0,-20} {1:C}", item.Name, item.Price);
            }
            if (table.Client.ClientType == ClientType.Special)
            {
                Console.WriteLine("{0,-20} {1:C}", "Total Amount: ",
                    table.Check.Amount - table.Check.Amount * Check.discountForSpecials);
                Console.WriteLine("{0,-20} {1:C}", "Discount: ", 
                    table.Check.Amount * Check.discountForSpecials);
            }
            else
            {
                Console.WriteLine("{0,-20} {1:C}", "Total Amount: ", table.Check.Amount);
            }
        }

        public void CalculateCheck(Table table)
        {
            decimal sum = 0;
            
            foreach (var item in table.Order.OrderList)
            {
                sum += (decimal)item.Price;
            }

            table.Check.Amount = sum;
        }

        public void RemoveItemFromOrder(Table table, MenuItem item)
        {
            table.Order.RemoveItem(item);
        }

        public void CancelOrder(Table table)
        {
            table.Order.RemoveOrder();
        }

        public void CloseTable(Table table, CheckPaymentMethod payMethod)
        {
            table.Check.PaymentMethod = payMethod;
            Report.reportsFromTables.Add(table, this);
            table.TableStatus = TableStatus.Free;
        }
    }
}

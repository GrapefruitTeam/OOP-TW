namespace RestaurantApp
{
    using System;
    using System.Text;

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
            var sb = new StringBuilder();

            sb.AppendLine(string.Format("CHECK table {0}:", ServingArea.Tables.IndexOf(table) + 1));

            foreach (var item in table.Order.OrderList)
            {
                sb.AppendLine(string.Format("{0,-20} {1:C}", item.Name, item.Price));
            }

            if (table.Client.ClientType == ClientType.Special)
            {
                sb.AppendLine(string.Format(
                    "{0,-20} {1:C}",
                    "Total Amount: ",
                    table.Check.Amount - (table.Check.Amount * Check.DiscountForSpecials)));
                sb.AppendLine(string.Format(
                    "{0,-20} {1:C}",
                    "Discount: ",
                    table.Check.Amount * Check.DiscountForSpecials));
            }
            else
            {
                sb.AppendLine(string.Format("{0,-20} {1:C}", "Total Amount: ", table.Check.Amount));
            }

            Console.WriteLine(sb.ToString());
        }

        public void CalculateCheck(Table table)
        {
            decimal sum = 0;

            foreach (var item in table.Order.OrderList)
            {
                sum += item.Price;
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
            table.Check.CheckDateAndTime = DateTime.Now;
            Report.ReportsFromTables.Add(table, this);
            table.TableStatus = TableStatus.Free;
        }
    }
}

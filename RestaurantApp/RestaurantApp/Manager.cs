namespace RestaurantApp
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Manager : AuthorizedEmployee, IOrder, ICancelOrder, IReserve,
        ICancelReservation, ICheckable, IReport, ICloseTable
    {
        public Manager(string name, string employeeId, string password)
            : base(name, employeeId, password)
        {
        }

        public void ReserveTable(Table table, ClientType type)
        {
            if (table.TableStatus != TableStatus.Free)
            {
                Console.WriteLine("Table is not free.");
            }
            else
            {
                table.TableStatus = TableStatus.Reserved;
                table.Client.ClientType = type;
            }
        }

        public void CancelReservation(Table table)
        {
            if (table.TableStatus != TableStatus.Reserved)
            {
                Console.WriteLine("Table is not reserved.");
            }
            else
            {
                table.TableStatus = TableStatus.Free;
            }
        }

        public void AddMenuItemToOrder(Table table, MenuItem item)
        {
            table.Order.AddItem(item);
        }

        public void RemoveItemFromOrder(Table table, MenuItem item)
        {
            table.Order.RemoveItem(item);
        }

        public void CancelOrder(Table table)
        {
            table.Order.RemoveOrder();
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
                Console.WriteLine("{0,-20} {1:C}", "Total Amount: ", table.Check.Amount - (table.Check.Amount * Check.DiscountForSpecials));
                Console.WriteLine("{0,-20} {1:C}", "Discount: ", table.Check.Amount * Check.DiscountForSpecials);
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

        public void CreateReport()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("{0,15}{1,15}{2,15}{3,15}",
                "Check amount",
                "Payment method",
                "Served by",
                "Employee id"));

            foreach (var item in Report.reportsFromTables)
            {
                sb.AppendLine(string.Format("{0,15:C}{1,15}{2,15}{3,15}",
                    item.Key.Check.Amount,
                    item.Key.Check.PaymentMethod,
                    item.Value.Name,
                    item.Value.EmployeeId));
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }

        public void CloseTable(Table table, CheckPaymentMethod payMethod)
        {
            table.Check.PaymentMethod = payMethod;
            Report.reportsFromTables.Add(table, this);
            table.TableStatus = TableStatus.Free;
        }
    }
}

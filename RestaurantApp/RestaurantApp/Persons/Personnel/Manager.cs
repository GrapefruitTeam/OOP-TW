namespace RestaurantApp
{
    using System;
    using System.Linq;
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
            StartRestaurant.dishesToCook.AddMenuItem(item);
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

        public void CreateReport(string startDate, string endDate)
        {
            DateTime start = Convert.ToDateTime(startDate);
            DateTime end = Convert.ToDateTime(endDate);

            var sb = new StringBuilder();

            sb.AppendLine(string.Format(
                "{0,20}{1,15}{2,15}{3,15}{4,15}",
                "Date",
                "Check amount",
                "Payment method",
                "Served by",
                "Employee id"));

            var sumOfChecks = 0M;
            foreach (var item in Report.ReportsFromTables)
            {
                if (item.Key.Check.CheckDateAndTime >= start &&
                    item.Key.Check.CheckDateAndTime <= end)
                {
                    sb.AppendLine(string.Format(
                        "{0,20}{1,15:C}{2,15}{3,15}{4,15}",
                        item.Key.Check.CheckDateAndTime.ToString(format: "yyyy/MM/dd HH:mm"),
                        item.Key.Check.Amount,
                        item.Key.Check.PaymentMethod,
                        item.Value.Name,
                        item.Value.EmployeeId));
                    sb.AppendLine();
                    sumOfChecks += item.Key.Check.Amount;
                }
            }

            sb.Append(string.Format("Total: {0:C}", sumOfChecks));

            Console.WriteLine(sb.ToString());
        }

        public void CloseTable(Table table, CheckPaymentMethod payMethod)
        {
            table.Check.PaymentMethod = payMethod;
            table.Check.CheckDateAndTime = DateTime.Now;
            Report.ReportsFromTables.Add(table, this);
            table.TableStatus = TableStatus.Free;
        }

        public void CreateEmployeeReport(AuthorizedEmployee employee, string startDate, string endDate)
        {
            DateTime start = Convert.ToDateTime(startDate);
            DateTime end = Convert.ToDateTime(endDate);

            var sb = new StringBuilder();

            sb.AppendLine(string.Format("Report on employee {0} - {1}", employee.Name, employee.EmployeeId));

            var selectedEmployee = Report.ReportsFromTables
                .Where(x => x.Value == employee)
                .Select(x => x);

            var checksSortedByDate = selectedEmployee
                .Where(x => x.Key.Check.CheckDateAndTime >= start &&
                x.Key.Check.CheckDateAndTime <= end)
                .Select(x => x);

            var checksGroupedByPaymentMethod = checksSortedByDate
                .GroupBy(x => x.Key.Check.PaymentMethod)
                .Select(x => x);

            foreach (var group in checksGroupedByPaymentMethod)
            {
                sb.Append(string.Format("{0}", group.Key));
                decimal sum = 0M;
                foreach (var item in group)
                {
                    sum += item.Key.Check.Amount;
                }

                sb.Append(string.Format(" {0,-10:C}", sum));
            }

            sb.AppendLine();
            sb.AppendLine(string.Format("Total: {0:C}", selectedEmployee.Sum(x => x.Key.Check.Amount)));

            Console.WriteLine(sb.ToString());
        }
    }
}

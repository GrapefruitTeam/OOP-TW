namespace RestaurantApp
{
    using System;
    using System.Text;

    using RestaurantApp.Engine;
    using RestaurantApp.Interfaces;
    using RestaurantApp.Persons.Personnel;

    public class Waiter : AuthorizedEmployee, IOrder, ICancelOrder, ICheckable, ICloseTable
    {
        public Waiter(string name, string employeeId, string password)
            : base(name, employeeId, password)
        {
        }

        public Busser WaiterBusser { get; private set; }

        public void AssignedABusser(Busser busser)
        {
            // this is used in the CleanTable() in this class
            this.WaiterBusser = busser;
        }

        public void AddMenuItemToOrder(Table table, MenuItem item)
        {
            table.Order.AddItem(item);
            StartRestaurant.DishesToCook.AddMenuItem(item);
        }

        public void PrintCheck(Table table)
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("CHECK table {0}:", ServingArea.Tables.IndexOf(table) + 1));

            foreach (var item in table.Order.OrderList)
            {
                sb.AppendLine(string.Format("{0,-20} {1:C}", item.Name, item.Price));
            }

            sb.AppendLine(string.Format("{0,-20} {1:C}", "Total Amount: ", table.Check.Amount));

            if (table.Client.ClientType == ClientType.Special)
            {
                sb.AppendLine(string.Format("{0,-20} {1:C}", "Discount: ", table.Check.Discount));
            }

            Console.WriteLine(sb.ToString());
        }

        public void CalculateCheck(Table table)
        {
            foreach (var item in table.Order.OrderList)
            {
                table.Check.Amount += item.Price;
            }

            if (table.Client.ClientType == ClientType.Special)
            {
                table.Check.Discount = table.Check.Amount * Check.DiscountForSpecials;
                table.Check.Amount -= table.Check.Discount;
            }
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

            this.CleanTable(table);
        }

        private void CleanTable(Table table)
        {
            // if the waiter doesnt have a Busser assigned to him, he will clean the table and set its status to free
            if (this.WaiterBusser == null)
            {
                table.TableStatus = TableStatus.Free;
            }
            else
            {
                this.WaiterBusser.CleanTable(table);
            }
        }
    }
}

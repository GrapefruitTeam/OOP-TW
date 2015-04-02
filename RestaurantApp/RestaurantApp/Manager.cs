namespace RestaurantApp
{
    using System;

    public class Manager : AuthorizedEmployee, IOrder, ICancelOrder, IReserve, ICancelReservation, ICheckable
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
            Console.WriteLine("CHECK:");
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
    }
}

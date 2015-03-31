using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp
{
    class StartRestaurant
    {
        static void Main()
        {
            // Testing ServingArea.cs
            ServingArea.Tables[2].TableStatus = TableStatus.Occupied;
            ServingArea.Tables[5].TableStatus = TableStatus.Reserved;

            foreach (var item in ServingArea.Tables)
            {
                Console.WriteLine(item.TableStatus);
            }

            //Testing Hostess
            Hostess hostess = new Hostess("Penka", "12345", "password");
            hostess.ReserveTable(ServingArea.Tables[2]);
            hostess.ReserveTable(ServingArea.Tables[1]);
            hostess.CancelReservation(ServingArea.Tables[5]);
            
            Console.WriteLine();
            Console.WriteLine(ServingArea.Tables[2].TableStatus);
            Console.WriteLine(ServingArea.Tables[1].TableStatus);
            Console.WriteLine(ServingArea.Tables[5].TableStatus);
            Console.WriteLine();

            //Testing Waiter
            Waiter waiter = new Waiter("Todor", "56789", "password");
            Table table = new Table();
            waiter.AddMenuItemToOrder(table, "Beer");
            waiter.AddMenuItemToOrder(table, "Soft drink");
            waiter.AddMenuItemToOrder(table, "French Fries");
            waiter.PrintCheck(table);
        }
    }
}
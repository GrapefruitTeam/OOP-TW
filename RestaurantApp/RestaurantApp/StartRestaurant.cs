﻿using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp
{
    class StartRestaurant
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            // Testing ServingArea.cs
            ServingArea.Tables[2].TableStatus = TableStatus.Occupied;
            ServingArea.Tables[5].TableStatus = TableStatus.Reserved;

            foreach (var item in ServingArea.Tables)
            {
                Console.WriteLine(item.TableStatus);
            }

            Console.WriteLine();

            //Testing Hostess
            Hostess hostess = new Hostess("Penka", "12345", "password");
            hostess.ReserveTable(ServingArea.Tables[2], ClientType.Regular);
            hostess.ReserveTable(ServingArea.Tables[1], ClientType.Special);
            hostess.CancelReservation(ServingArea.Tables[5]);

            Console.WriteLine();
            Console.WriteLine(ServingArea.Tables[2].TableStatus);
            Console.WriteLine(ServingArea.Tables[1].TableStatus);
            Console.WriteLine(ServingArea.Tables[5].TableStatus);
            Console.WriteLine();

            //Testing Waiters
            MenuItem menu = new MenuItem();
            IList<MenuItem> menuList = menu.InitializeMenu();
            
            Waiter waiter = new Waiter("Todor", "56789", "password");
            waiter.AddMenuItemToOrder(ServingArea.Tables[1], menuList[2]);
            waiter.AddMenuItemToOrder(ServingArea.Tables[1], menuList[1]);
            waiter.AddMenuItemToOrder(ServingArea.Tables[1], menuList[0]);
            waiter.RemoveItemFromOrder(ServingArea.Tables[2], menuList[0]);
            waiter.AddMenuItemToOrder(ServingArea.Tables[2], menuList[5]);
            waiter.CalculateCheck(ServingArea.Tables[1]);
            waiter.PrintCheck(ServingArea.Tables[1]);
            waiter.CancelOrder(ServingArea.Tables[1]);
            waiter.CloseTable(ServingArea.Tables[1], CheckPaymentMethod.Cash);
            waiter.CloseTable(ServingArea.Tables[2], CheckPaymentMethod.Card);

            Waiter waiter2 = new Waiter("Alex", "88888", "password8");
            waiter2.AddMenuItemToOrder(ServingArea.Tables[7], menuList[8]);
            waiter2.CalculateCheck(ServingArea.Tables[7]);
            waiter2.PrintCheck(ServingArea.Tables[7]);
            waiter2.CloseTable(ServingArea.Tables[7], CheckPaymentMethod.Cash);

            Console.WriteLine();
            foreach (var item in Report.reportsFromTables)
            {
                Console.WriteLine("{0:C} {1} {2} {3}", 
                    item.Key.Check.Amount,
                    item.Key.Check.PaymentMethod,
                    item.Value.Name, 
                    item.Value.EmployeeId);
            }
        }
    }
}
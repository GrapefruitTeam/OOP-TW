﻿namespace RestaurantApp
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;

    internal class StartRestaurant
    {
        internal static void Main()
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

            // Testing Hostess
            Hostess hostess = new Hostess("Penka", "12345", "password");
            hostess.ReserveTable(ServingArea.Tables[2], ClientType.Regular);
            hostess.ReserveTable(ServingArea.Tables[1], ClientType.Special);
            hostess.CancelReservation(ServingArea.Tables[5]);

            Console.WriteLine();
            Console.WriteLine(ServingArea.Tables[2].TableStatus);
            Console.WriteLine(ServingArea.Tables[1].TableStatus);
            Console.WriteLine(ServingArea.Tables[5].TableStatus);
            Console.WriteLine();

            // Testing Waiter
            MenuItem menu = new MenuItem();
            IList<MenuItem> menuList = menu.InitializeMenu();
            Waiter waiter = new Waiter("Todor", "56789", "password");
            waiter.AddMenuItemToOrder(ServingArea.Tables[1], menuList[2]);
            waiter.AddMenuItemToOrder(ServingArea.Tables[1], menuList[1]);
            waiter.AddMenuItemToOrder(ServingArea.Tables[1], menuList[0]);
            waiter.RemoveItemFromOrder(ServingArea.Tables[1], menuList[0]);
            waiter.CalculateCheck(ServingArea.Tables[1]);
            waiter.PrintCheck(ServingArea.Tables[1]);
            waiter.CancelOrder(ServingArea.Tables[1]);
            waiter.CalculateCheck(ServingArea.Tables[1]);
            waiter.PrintCheck(ServingArea.Tables[1]);
        }
    }
}
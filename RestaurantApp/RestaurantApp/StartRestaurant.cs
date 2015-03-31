using System;
using System.Collections.Generic;

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
<<<<<<< HEAD
            Console.WriteLine();
            Menu.ShowMenu(Menu.appetizers);
            Menu.ShowMenu(Menu.mainDish);
            Menu.ShowMenu(Menu.desserts);
            Menu.ShowMenu(Menu.drinks);
            

=======

            //Testing Hostess
            Hostess hostess = new Hostess("Penka", "12345", "password");
            hostess.ReserveTable(ServingArea.Tables[2]);
            hostess.ReserveTable(ServingArea.Tables[1]);
            hostess.CancelReservation(ServingArea.Tables[5]);
            
            Console.WriteLine();
            Console.WriteLine(ServingArea.Tables[2].TableStatus);
            Console.WriteLine(ServingArea.Tables[1].TableStatus);
            Console.WriteLine(ServingArea.Tables[5].TableStatus);
>>>>>>> origin/master
        }
    }
}
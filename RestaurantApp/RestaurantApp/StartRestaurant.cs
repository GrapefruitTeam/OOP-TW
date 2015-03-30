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
        }
    }
}
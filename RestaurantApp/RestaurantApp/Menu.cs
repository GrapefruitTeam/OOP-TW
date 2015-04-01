namespace RestaurantApp
{
    using System;
    using System.Collections.Generic;

    public static class Menu
    {
        public static Dictionary<string, double> MenuList = new Dictionary<string, double>()
        {
            { "1 .Stuffed Mushrooms", 5.2 },
            { "2. Fried Calamari", 5.5 },
            { "3. French Fries", 3.4 },
            { "4. Bourbon Chicken", 8.4 },
            { "5. Crock-Pot Chicken with Cream Cheese", 9.4 },
            { "6. Creamy Cajun Chicken Pasta", 8.6 },
            { "7. Strawberry-Coconut Pie", 6.5 },
            { "8. White Chocolate & Strawberry Cake", 7.5 },
            { "9. Milk Chocolate Cream Pie", 7 },
            { "10. Beer", 2 },
            { "11. Soft drink", 1.8 },
            { "12. Coffee", 1.6 }
        };

        public static void ShowMenu()
        {
            foreach (var item in Menu.MenuList)
            {
                Console.WriteLine("{0} - {1:C}", item.Key, item.Value);
            }

            Console.WriteLine();
        }
    }
}
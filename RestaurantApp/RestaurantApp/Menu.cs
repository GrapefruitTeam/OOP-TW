using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public static class Menu
    {
        public static Dictionary<string, double> appetizers = new Dictionary<string, double>()
        {
            { "Stuffed Mushrooms", 5.2 },
            { "Fried Calamari", 5.5 },
            { "French Fries", 3.4 }
        };

        public static Dictionary<string, double> mainDish = new Dictionary<string, double>()
        {
            { "Bourbon Chicken", 8.4 },
            { "Crock-Pot Chicken With Black Beans & Cream Cheese", 9.4 },
            { "Creamy Cajun Chicken Pasta", 8.6 }
        };

        public static Dictionary<string, double> desserts = new Dictionary<string, double>()
        {
            { "Strawberry-Coconut Pie", 6.5 },
            { "White Chocolate & Strawberry Layer Cake", 7.5 },
            { "Milk Chocolate Cream Pie", 7 }
        };

        public static Dictionary<string, double> drinks = new Dictionary<string, double>()
        {
            { "Beer", 2 },
            { "Soft drink", 1.8 },
            { "Coffee", 1.6 }
        };

        public static void ShowMenu(Dictionary<string, double> menu)
        {
            foreach (var x in menu )
            {
                Console.WriteLine("{0}", x);
            }
            Console.WriteLine();
        }
    }
}
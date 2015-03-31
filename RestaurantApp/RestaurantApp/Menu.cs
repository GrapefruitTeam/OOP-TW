using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public static class Menu
    {
        public static Dictionary<string, double> MenuList = new Dictionary<string, double>()
        {
            { "Stuffed Mushrooms", 5.2},
            { "Fried Calamari", 5.5 },
            { "French Fries", 3.4},
            { "Bourbon Chicken", 8.4 },
            { "Crock-Pot Chicken With Black Beans & Cream Cheese", 9.4 },
            { "Creamy Cajun Chicken Pasta", 8.6 },
            { "Strawberry-Coconut Pie", 6.5 },
            { "White Chocolate & Strawberry Layer Cake", 7.5 },
            { "Milk Chocolate Cream Pie", 7 },
            { "Beer", 2 },
            { "Soft drink", 1.8 },
            { "Coffee", 1.6 }
        };
    }
}
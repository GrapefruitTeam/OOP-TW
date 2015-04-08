namespace RestaurantApp
{
    using System;

    using RestaurantApp.Engine;
    using RestaurantApp.Persons.Personnel;

    public class Kitchen
    {
        public Kitchen()
        {
            StartRestaurant.dishesToCook.MyEvent += new MyDelegate(PrintIncomingOrder);
        }

        public void PrintIncomingOrder(MenuItem item)
        {
            Console.WriteLine("New order received: {0}", item.Name);
        }
    }
}

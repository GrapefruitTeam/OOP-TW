namespace RestaurantApp.Persons.Personnel
{
    using System;

    using RestaurantApp.Engine;

    public class Busser : Employee
    {
        public Busser(string name, string employeeId)
            : base(name, employeeId)
        {
            // the job of the Busser is to clean the table after it has been used by a customer

            // only the Waiter(or someone with higher status in the resturant) can tell when to clean the table, which
            // means that the Waiter has to have a method that calls a Busser to clean certain table
        }

        public void CleanTable(Table table)
        {
            table.TableStatus = TableStatus.Free;
        }

        // TODO: Create a function "CleanKitchen" maybe
        // public void CleanKitchen(Kitchen kitchen)
        // {
            // kitchen.KitchenStatus = KitchenStatus.Clean;
        // }
    }
}
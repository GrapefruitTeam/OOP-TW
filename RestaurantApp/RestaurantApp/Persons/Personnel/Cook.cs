namespace RestaurantApp.Persons.Personnel
{
    using System;

    public class Cook : Employee
    {
        public Cook(string name, string employeeId)
            : base(name, employeeId)
        {
        }

        // new !!!
        public Busser CookBusser { get; private set; }

        // new !!!
        public void AssignedABusser(Busser busser)
        {
            // this is used in the CleanTable() in this class
            this.CookBusser = busser;
        }

        // this function is called depending on DishesToCook items (on every 10 new items, the kitchen gets Dirty and needs to be cleaned) 
        //        public void CleanKitchen(Kitchen kitchen)
        //        {
        //            //if the Cook doesnt have a Busser assigned to him, he will clean the Kitchen and set Kitchen status to Clean
        //            if (this.CookBusser == null)
        //            {
        //                kitchen.KitchenStatus = KitchenStatus.Clean;
        //            }
        //            else
        //            {
        //                this.CookBusser.CleanKitchen(kitchen);
        //            }
        //        }
    }
}
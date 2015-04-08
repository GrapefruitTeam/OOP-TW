namespace RestaurantApp.Interfaces
{
    using RestaurantApp.Engine;

    public interface IOrder
    {
        void AddMenuItemToOrder(Table table, MenuItem item);
    }
}
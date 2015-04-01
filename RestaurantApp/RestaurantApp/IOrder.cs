namespace RestaurantApp
{
    public interface IOrder
    {
        void AddMenuItemToOrder(Table table, MenuItem item);
    }
}
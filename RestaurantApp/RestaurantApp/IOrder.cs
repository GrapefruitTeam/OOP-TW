namespace RestaurantApp
{
    public interface IOrder
    {
        void AddMenuItemToOrder(Table table, string item);
    }
}
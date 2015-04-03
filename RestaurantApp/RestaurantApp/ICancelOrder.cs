namespace RestaurantApp
{
    public interface ICancelOrder
    {
        void RemoveItemFromOrder(Table table, MenuItem item);

        void CancelOrder(Table table);
    }
}
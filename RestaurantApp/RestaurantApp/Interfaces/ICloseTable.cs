namespace RestaurantApp
{
    internal interface ICloseTable
    {
        void CloseTable(Table table, CheckPaymentMethod payMethod);
    }
}
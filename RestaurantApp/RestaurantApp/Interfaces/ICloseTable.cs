namespace RestaurantApp
{
    using RestaurantApp.Engine;

    internal interface ICloseTable
    {
        void CloseTable(Table table, CheckPaymentMethod payMethod);
    }
}
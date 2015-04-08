namespace RestaurantApp.Interfaces
{
    using RestaurantApp.Engine;

    public interface IReserve
    {
        void ReserveTable(Table table, ClientType type);
    }
}
namespace RestaurantApp.Interfaces
{
    using RestaurantApp.Engine;

    public interface ICancelReservation
    {
        void CancelReservation(Table table);
    }
}
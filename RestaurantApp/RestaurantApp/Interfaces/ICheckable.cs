namespace RestaurantApp.Interfaces
{
    using RestaurantApp.Engine;

    public interface ICheckable
    {
        void PrintCheck(Table table);

        void CalculateCheck(Table table);
    }
}
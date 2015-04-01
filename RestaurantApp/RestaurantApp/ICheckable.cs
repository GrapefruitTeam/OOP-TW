namespace RestaurantApp
{
    public interface ICheckable
    {
        void PrintCheck(Table table);

        void CalculateCheck(Table table);
    }
}
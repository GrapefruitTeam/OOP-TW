namespace RestaurantApp
{
    public class Table
    {
        public Table()
        {
            this.TableStatus = TableStatus.Free;
            this.Order = new Order();
        }

        public TableStatus TableStatus { get; set; }

        public Order Order { get; set; }
    }
}
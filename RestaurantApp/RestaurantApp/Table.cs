namespace RestaurantApp
{
    public class Table
    {
        public Table()
        {
            this.TableStatus = TableStatus.Free;
            this.Client = new Client();
            this.Order = new Order();
        }

        public TableStatus TableStatus { get; set; }

        public Client Client { get; set; }

        public Order Order { get; set; }
    }
}
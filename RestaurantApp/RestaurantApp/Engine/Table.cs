namespace RestaurantApp.Engine
{
    using RestaurantApp.Persons.Other;

    public class Table
    {
        public Table()
        {
            this.TableStatus = TableStatus.Free;
            this.Client = new Client();
            this.Order = new Order();
            this.Check = new Check();
        }

        public TableStatus TableStatus { get; set; }

        public Client Client { get; set; }

        public Check Check { get; set; }

        public Order Order { get; set; }
    }
}
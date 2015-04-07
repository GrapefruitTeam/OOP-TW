namespace RestaurantApp
{
    public abstract class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public Person()
        {
        }

        public string Name { get; set; }
    }
}
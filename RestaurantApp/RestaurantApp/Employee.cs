namespace RestaurantApp
{
    public abstract class Employee : Person
    {
        public Employee(string name, string employeeId)
            : base(name)
        {
            this.EmployeeId = employeeId;
        }

        public string EmployeeId { get; set; }
    }
}
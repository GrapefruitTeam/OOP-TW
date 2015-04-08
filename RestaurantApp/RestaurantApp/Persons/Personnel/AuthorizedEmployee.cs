namespace RestaurantApp.Persons.Personnel
{
    public abstract class AuthorizedEmployee : Employee
    {
        public AuthorizedEmployee(string name, string employeeId, string password)
            : base(name, employeeId)
        {
            this.Password = password;
        }

        public string Password { get; protected set; }
    }
}
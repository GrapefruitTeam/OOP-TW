namespace RestaurantApp.Persons.Personnel
{
    using RestaurantApp.Engine;

    public abstract class Employee : Person
    {
        private string id;

        public Employee(string name, string employeeId)
            : base(name)
        {
            this.EmployeeId = employeeId;
        }

        public string EmployeeId
        {
            get
            {
                return this.id;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(
                    value,
                    string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Employee ID "));

                // maybe this validation is not necessary
                // the ID cant be more characters then this, because lets say the name is Christohpher(12 chars) -> his ID could be Christohpher01 or Christohpher0A
                // there is a very slim chance that there will be 256 employees with that name(if we use the last 2 characters of the ID as a 16binary system)
                Validator.CheckIfStringLengthIsValid(
                    value,
                    this.MaxNameLength + 2,
                    this.MinNameLength,
                    string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Employee ID", this.MinNameLength, this.MinNameLength + 2));

                this.id = value;
            }
        }
    }
}
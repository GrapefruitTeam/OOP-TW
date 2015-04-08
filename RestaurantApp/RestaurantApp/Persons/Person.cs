namespace RestaurantApp
{
    using System;

    using RestaurantApp.Engine;

    public abstract class Person
    {
        // readonly or const
        protected readonly int MinNameLength = 2;
        protected readonly int MaxNameLength = 12;

        private string name;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person()
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(
                    value,
                    string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "person`s name"));

                Validator.CheckIfStringLengthIsValid(
                    value,
                    this.MaxNameLength,
                    this.MinNameLength,
                    string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "person`s name", this.MinNameLength, this.MaxNameLength));

                this.name = value;
            }
        }
    }
}
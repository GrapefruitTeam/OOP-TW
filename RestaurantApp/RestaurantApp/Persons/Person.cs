namespace RestaurantApp
{
    using System;

    public abstract class Person
    {
        //readonly or const
        protected readonly int minNameLength = 2;
        protected readonly int maxNameLength = 12;

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
                Validator.CheckIfStringIsNullOrEmpty(value, 
                    string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty,"person`s name"));

                Validator.CheckIfStringLengthIsValid(value,
                    maxNameLength,
                    minNameLength,
                    string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty,"person`s name", minNameLength, maxNameLength));
            }
        }
    }
}
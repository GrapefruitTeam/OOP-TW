// reference https://msdn.microsoft.com/en-us/library/aa288471%28v=vs.71%29.aspx or Structs Tutorial from microsoft
namespace RestaurantApp.Engine
{
    using System;

    public struct MenuStruct
    {
        private const int MinLength = 4;

        // must be a very fancy dish name to have 80 chars in it
        private const int MaxLength = 80;

        private string firstMeal;
        private string secondMeal;
        private string beverage;

        public string FirstMeal
        {
            get
            {
                return this.firstMeal;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First meal cant be empty");
                }

                // first meal can be named with only one char, so we dont need to check for that 
                // but if we change our mind -> uncoment the below
                // if(value.Length < minLength || value.Length > maxLength )
                // throw new ArgumentNullException(string.Format("The name of the first meal must be between {0} and {1} length", minLength, maxLength ));
                this.firstMeal = value;
            }
        }

        public string SecondMeal
        {
            get
            {
                return this.secondMeal;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Second meal cant be empty or null");
                }

                // same logic goes for second meal 
                // if(value.Length < minLength || value.Length > maxLength )
                // throw new ArgumentNullException(string.Format("The name of the second meal must be between {0} and {1} length", minLength, maxLength ));
                this.secondMeal = value;
            }
        }

        public string Beverage
        {
            get
            {
                return this.beverage;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First meal cant be empty or null");
                }

                // same logic goes for the beverage 
                // if(value.Length < minLength || value.Length > maxLength )
                // throw new ArgumentNullException(string.Format("The name of the beverage must be between {0} and {1} length", minLength, maxLength ));
                this.beverage = value;
            }
        }

        public string DisplayMenu()
        {
            string menu = string.Format("First meal = {0}, Second meal = {1}, Beverage = {2}", this.FirstMeal, this.SecondMeal, this.Beverage);
            return menu;
        }
    }
}
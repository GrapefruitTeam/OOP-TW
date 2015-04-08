namespace RestaurantApp.Engine
{
    using System;
    class RestaurantException : ApplicationException
    {
        public RestaurantException(string message) 
            : base(message)
        {
        }

        public RestaurantException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}

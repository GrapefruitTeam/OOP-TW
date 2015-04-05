using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
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

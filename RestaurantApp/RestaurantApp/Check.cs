using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Check
    {
        public Check(Table table, CheckPaymentMethod paymentMethod)
        {
            this.PaymentMethod = paymentMethod;
        }

        public CheckPaymentMethod PaymentMethod { get; set; }
    }
}

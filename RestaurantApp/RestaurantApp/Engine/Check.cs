namespace RestaurantApp.Engine
{
    using System;
    
    public class Check
    {
        public const decimal DiscountForSpecials = 0.1M; 

        public Check()
        {
        }

        public decimal Amount { get; set; }

        public decimal Discount { get; set; }

        public CheckPaymentMethod PaymentMethod { get; set; }

        public DateTime CheckDateAndTime { get; set; }
    }
}
namespace RestaurantApp
{
    public class Check
    {
        public const decimal discountForSpecials = 0.1M; 

        public Check()
        {
        }

        public decimal Amount { get; set; }

        public CheckPaymentMethod PaymentMethod { get; set; }

    }
}
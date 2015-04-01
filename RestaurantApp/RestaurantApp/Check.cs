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
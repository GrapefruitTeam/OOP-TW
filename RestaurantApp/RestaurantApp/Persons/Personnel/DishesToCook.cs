namespace RestaurantApp.Persons.Personnel
{
    using System.Collections;

    using RestaurantApp.Engine;

    public delegate void MyDelegate(MenuItem item);

    public class DishesToCook : ArrayList
    {
        public event MyDelegate MyEvent;

        public void AddMenuItem(MenuItem item)
        {
            this.Add(item);
            this.OnChanged(item);
        }

        protected virtual void OnChanged(MenuItem item)
        {
            if (this.MyEvent != null)
            {
                this.MyEvent(item);
            }
        }
    }
}

namespace RestaurantApp.Persons.Personnel
{
    using System.Collections;

    using RestaurantApp.Engine;

    public delegate void MyDelegate(MenuItem item);

    public class DishesToCook : ArrayList
    {
        public event MyDelegate MyEvent;

        protected virtual void OnChanged(MenuItem item)
        {
            if (MyEvent != null)
            {
                MyEvent(item);
            }
        }

        public void AddMenuItem(MenuItem item)
        {
            Add(item);
            OnChanged(item);
        }
    }
}

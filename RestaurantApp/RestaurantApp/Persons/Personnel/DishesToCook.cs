using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Persons.Personnel
{
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

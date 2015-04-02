<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace RestaurantApp
=======
﻿namespace RestaurantApp
>>>>>>> 4f0c87a4376e0f9539f7b2e6b58492bb43f4fe36
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class MenuItem
    {
        private string name;
        private double price;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;
            }
        }

        public MenuItem()
        {
            this.Name = name;
            this.Price = price;
        }

        public IList<MenuItem> InitializeMenu()
        {
            int count = File.ReadLines(@"..\..\Menu.txt").Count();
            MenuItem[] menuItems = new MenuItem[count];

            for (var i = 0; i < menuItems.Length; i++)
            {
                menuItems[i] = new MenuItem();
            }

            int index = 0;
            using (StreamReader reader = new StreamReader(@"..\..\Menu.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] data = line.Split(';');
                    menuItems[index].Name = data[0];
                    menuItems[index].Price = double.Parse(data[1]);

                    index++;
                    line = reader.ReadLine();
                }
            }

            return menuItems;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RestaurantApp
{
    public class MenuItem
    {
        private string name;
        private double price;

        public string Name { get { return this.name; } set { this.name = value; } }
        public double Price { get { return this.price; } set { this.price = value; } }

        public MenuItem()
        {
            this.Name = name;
            this.Price = price;
        }

        public MenuItem[] InitializeMenu()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(@"..\..\Menu.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    count++;
                    line = reader.ReadLine();
                }
            }
            
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
                    string[] data = new string[2];
                    data = line.Split(' ').ToArray();
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
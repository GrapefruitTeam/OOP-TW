namespace RestaurantApp.Engine
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class MenuItem
    {
        private const string MenuFilePath = @"..\..\Engine\Menu.txt";

        private string name;
        private decimal price;

        public MenuItem()
        {
            this.Name = this.name;
            this.Price = this.price;
        }

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

        public decimal Price
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

        public IList<MenuItem> InitializeMenu()
        {
            int count = File.ReadLines(MenuFilePath).Count();
            MenuItem[] menuItems = new MenuItem[count];

            for (var i = 0; i < menuItems.Length; i++)
            {
                menuItems[i] = new MenuItem();
            }

            int index = 0;
            using (StreamReader reader = new StreamReader(MenuFilePath))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] data = line.Split(';');
                    menuItems[index].Name = data[0];
                    menuItems[index].Price = decimal.Parse(data[1]);

                    index++;
                    line = reader.ReadLine();
                }
            }

            return menuItems;
        }

        public override string ToString()
        {
            return string.Format("{0}", this.Name);
        }
    }
}
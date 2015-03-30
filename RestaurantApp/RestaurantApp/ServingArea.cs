using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public static class ServingArea
    {
        private const int numberOfTables = 8;
        private static List<Table> tables;

        static ServingArea()
        {
            tables = new List<Table>(8);
            for (int i = 0; i < numberOfTables; i++)
            {
                tables.Add(new Table());
            }
        }

        public static List<Table> Tables
        {
            get { return new List<Table>(tables); }
            private set { tables = value; }
        }
    }
}

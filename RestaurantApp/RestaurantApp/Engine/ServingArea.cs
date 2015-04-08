namespace RestaurantApp.Engine
{
    using System.Collections.Generic;

    public static class ServingArea
    {
        private const int NumberOfTables = 8;

        private static IList<Table> tables;

        static ServingArea()
        {
            tables = new List<Table>(NumberOfTables);
            for (int i = 0; i < NumberOfTables; i++)
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
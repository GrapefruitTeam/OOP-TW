namespace RestaurantApp
{
    using System.Collections.Generic;

    public static class Report
    {
        private static IDictionary<Table, AuthorizedEmployee> reportsFromTables = new Dictionary<Table, AuthorizedEmployee>();

        public static IDictionary<Table, AuthorizedEmployee> ReportsFromTables
        {
            get { return reportsFromTables; }
            private set { reportsFromTables = value; }
        }
    }
}
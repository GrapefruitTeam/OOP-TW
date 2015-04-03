namespace RestaurantApp
{
    using System.Collections.Generic;

    public static class Report
    {
        private static Dictionary<Table, AuthorizedEmployee> reportsFromTables = new Dictionary<Table, AuthorizedEmployee>();

        public static Dictionary<Table, AuthorizedEmployee> ReportsFromTables
        {
            get { return reportsFromTables; }
            private set { reportsFromTables = value; }
        }
    }
}
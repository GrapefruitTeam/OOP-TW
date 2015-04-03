using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Table
    {
        public Order TableOrder { get; set; }

        public Table()
        {
            this.TableStatus = TableStatus.Free;
            this.TableOrder = new Order();
        }

        public TableStatus TableStatus { get; set; }

        public static void Order(Table thisTable)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Table
    {
        public Table()
        {
            this.TableStatus = TableStatus.Free;
        }

        public TableStatus TableStatus { get; set; }
    }
}

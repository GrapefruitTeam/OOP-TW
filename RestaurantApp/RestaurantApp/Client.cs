using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Client : Person
    {
        public Client()
            : base()
        {
            this.ClientType = ClientType.Regular;
        }

        public Client(string name, ClientType clientType)
            : base(name)
        {
            this.ClientType = clientType;
        }

        public ClientType ClientType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.by.rfe.store.Queue
{
    class ClientOrder // Хранилище заказов клиентов
    {
        private static ClientOrder instance;
        private List<ClientOrder> orders;

        private ClientOrder()
        {
            instance = new ClientOrder();
        }

        public List<ClientOrder> Orders
        {
            get
            {
                return orders;
            }

        }

        public void addClientOrder(ClientOrder order)
        {
            orders.Add(order);
        }

        public static ClientOrder getInstance()
        {
            return instance;
        }

    }
}

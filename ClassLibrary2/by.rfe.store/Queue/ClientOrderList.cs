using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.by.rfe.store.Queue
{
   public class ClientOrderList // Хранилище заказов клиентов
    {
        private static ClientOrderList instance;
        private List<ClientOrderList> orders;

        private ClientOrderList()
        {
            instance = new ClientOrderList();
        }

        public List<ClientOrderList> Orders
        {
            get
            {
                return orders;
            }

        }

        public void addClientOrder(ClientOrderList order)
        {
            orders.Add(order);
        }

        public static ClientOrderList getInstance()
        {
            return instance;
        }

    }
}

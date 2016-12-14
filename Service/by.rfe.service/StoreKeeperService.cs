using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.by.rfe.store.Entity;
using ClassLibrary.by.rfe.store.Queue;

namespace Service.by.rfe.service
{
 public  class StoreKeeperService
    {
        private static StoreKeeperService INSTANCE = new StoreKeeperService();
        private StoreKeeperService() { }

        public static StoreKeeperService INSTANCE1
        {
            get
            {
                return INSTANCE;
            }
        }

        public List<ClientOrder> getClientOrders()
        {
            List<ClientOrder> orders = new List<ClientOrder>();
            foreach (ClientOrder order in ClientOrderList.getInstance().Orders)
            {
                if (order.getPayed() == true && !order.IsReady)
                    orders.Add(order);
            }
            return orders;
        }
        public List<ProviderOrder> getProviderOrders()
        {
            List<ProviderOrder> orders = new List<ProviderOrder>();
            foreach (ProviderOrder order in ProviderOrderList.getInstance().Orders)
            {
                if (order.getPayed() == true)
                    orders.Add(order);
            }
            return orders;
        }

        public void collectOrder(ClientOrder order)
        {
            order.IsReady = true;
        }
    }
}


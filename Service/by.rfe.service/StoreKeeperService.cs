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
        public void takeProviderOrder(ProviderOrder order)
        {
            if (order.ClientOrder == null)
            {
                Store.getInstance().addProduct(order.Product, order.getQuantity());
                ProviderOrderList.getInstance().Orders.Remove(order);
                return;
            }
            else
            {
                foreach (ClientOrder or in ClientOrderList.getInstance().Orders)
                {
                    if (or == order.ClientOrder)
                    {
                        if (or.getCountToEnd() < order.getQuantity())
                        {
                            Store.getInstance().addProduct(order.Product, order.getQuantity() - or.getCountToEnd());
                            or.setCountToEnd(0);
                            or.set(true);

                        }
                        if(or.getCountToEnd() == order.getQuantity())
                        {
                            or.setCountToEnd(0);
                            or.set(true);
                        }
                    ProviderOrderList.getInstance().Orders.Remove(order);
                    return;
                    }
                }
            }
        }
    }
}


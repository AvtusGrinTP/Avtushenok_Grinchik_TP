using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.by.rfe.store.Queue
{
    class ProviderOrder //хранилище заказов поставшиков
    {
        private static ProviderOrder instance;
        private List<ProviderOrder> orders;

        private ProviderOrder()
        {
            instance = new ProviderOrder();
        }

        public List<ProviderOrder> Orders
        {
            get
            {
                return orders;
            }

        }

        public void addProviderOrder(ProviderOrder order)
        {
            orders.Add(order);
        }

        public static ProviderOrder getInstance()
        {
            return instance;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.by.rfe.store.Queue
{
    class ProviderOrderList //хранилище заказов поставшиков
    {
        private static ProviderOrderList instance;
        private List<ProviderOrderList> orders;

        private ProviderOrderList()
        {
            instance = new ProviderOrderList();
        }

        public List<ProviderOrderList> Orders
        {
            get
            {
                return orders;
            }

        }

        public void addProviderOrder(ProviderOrderList order)
        {
            orders.Add(order);
        }

        public static ProviderOrderList getInstance()
        {
            return instance;
        }

    }
}

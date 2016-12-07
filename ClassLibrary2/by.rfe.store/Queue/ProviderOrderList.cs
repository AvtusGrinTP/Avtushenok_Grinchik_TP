using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.by.rfe.store.Entity;

namespace ClassLibrary.by.rfe.store.Queue
{
   public class ProviderOrderList //хранилище заказов поставшиков
    {
        private static ProviderOrderList instance = new ProviderOrderList();
        private List<ProviderOrder> orders = new List<ProviderOrder>();

        private ProviderOrderList()
        {
            orders.Add(new ProviderOrder(2,
                new Product("class2", "cat2", "type2", "Фирма йц"), 5, 124));
            orders.Add(new ProviderOrder(5,
               new Product("class5", "cat4", "type4", "ОАО 'Ээээ'"), 7,127));

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

        public static ProviderOrderList getInstance()
        {
            return instance;
        }

    }
}

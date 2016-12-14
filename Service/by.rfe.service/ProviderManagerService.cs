using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.by.rfe.store.Queue;
using ClassLibrary.by.rfe.store.Entity;

namespace Service.by.rfe.service
{
    public class ProviderManagerService
    {
        private static ProviderManagerService instance = new ProviderManagerService();
        private List<Provider> providerList = new List<Provider>();
        private ProviderManagerService()
        {
            providerList.Add(new Provider("рога и копыта 1", "wall street 1", "+375291111111"));
            providerList.Add(new Provider("рога и копыта 2", "wall street 2", "+375292222222"));
            providerList.Add(new Provider("рога и копыта 3", "wall street 3", "+375293333333"));
        }

        public List<Provider> ProviderList
        {
            get
            {
                return providerList;
            }
        }

        public static ProviderManagerService getInstance()
        {
            return instance;
        }

        public List<ProviderOrder> getProviderOrders()
        {
            ProviderOrderList list = ProviderOrderList.getInstance();
            return list.Orders;
        }

        public void makeOrder(int id, string name, int quantity, double price)
        {
            Provider provider = findProviderByName(name);
            ProviderOrderList providerOrderList = ProviderOrderList.getInstance();
            List<ProviderOrder> orders = providerOrderList.Orders;
            foreach (ProviderOrder or in orders)
            {
                if (or.getId().Equals(id))
                {
                    or.Provider = provider;
                    or.Price = price;
                    or.setQuantity(quantity);
                    
                }
            }
        }

        public bool deleteProvider(Provider provider)
        {
            foreach (ProviderOrder order in ProviderOrderList.getInstance().Orders)
            {
                if (order.Provider == provider)
                    return false;
            }
           ProviderList.Remove(provider);
           return true;
        }

        public void addProvider(string name, string adress, string phoneNumber)
        {
            Provider provider = new Provider(name, adress,phoneNumber);
            providerList.Add(provider);
        }

        public void addNewOrder(Product product, int quantity, double price, string providerName)
        {
            Provider provider = findProviderByName(providerName);
            ProviderOrder order = new ProviderOrder();
            order.setId(ProviderOrderList.getInstance().generateId());
            order.Product = product;
            order.setQuantity(quantity);
            order.Price = price;
            order.Provider = provider;
            ProviderOrderList.getInstance().addProviderOrder(order);
        }
        private Provider findProviderByName(string name)
        {
            Provider provider = null;
            foreach (Provider prov in ProviderList)
            {
                if (prov.Name.Equals(name))
                    provider = prov;
            }
            return provider;
        }

    }
}

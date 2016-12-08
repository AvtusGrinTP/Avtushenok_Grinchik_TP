using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.by.rfe.store.Queue;
using ClassLibrary.by.rfe.store.Entity;
using Service.by.rfe.service.exception;

namespace Service.by.rfe.service
{
   public class ClientManagerService
    {
        private static  ClientManagerService instance = new ClientManagerService();
        
        private ClientManagerService() {

        }

        public static ClientManagerService getInstance() {
            return instance;
        }

        public List<ClientOrder> getClientOrders()
        {
            return ClientOrderList.getInstance().Orders;
        }

        public void addClientOrder(int id, string classofProd, string category, string type, string name, int quantity, string clientName, string clientAddress, double price)
        {
            Product product = new Product(classofProd, category, type, name);
            Store store = Store.getInstance();
            int count = 0;
            if (!store.Products.TryGetValue(product, out count))
            {
                throw new ServiceException("Не найдено такого проудкта");
            }
            if (count > quantity)
            {
                count = count - quantity;
                store.Products.Remove(product);
                store.Products.Add(product, count);
                ClientOrderList clientorderList = ClientOrderList.getInstance();
                clientorderList.addClientOrder(new ClientOrder(id, product, quantity, clientName, clientAddress, true, 0, price));
                return;
            }
            if (count < quantity)
            {
                count = quantity - count;
                store.Products.Remove(product);
                store.Products.Add(product, 0);
                ClientOrderList clientorderList = ClientOrderList.getInstance();
                clientorderList.addClientOrder(new ClientOrder(id, product, quantity, clientName, clientAddress, false, count, price));
                ProviderOrderList providerOrderList = ProviderOrderList.getInstance();
                providerOrderList.addProviderOrder(new ProviderOrder(providerOrderList.generateId(), product, count, 0));
                return;
            }

            if (count == quantity)
            {
                count = quantity - count;
                store.Products.Remove(product);
                store.Products.Add(product, 0);
                ClientOrderList clientorderList = ClientOrderList.getInstance();
                clientorderList.addClientOrder(new ClientOrder(id, product, quantity, clientName, clientAddress, true, 0, price));
                return;
            }
        }

        public HashSet<string> getClass()
        {
            Store store = Store.getInstance();
            HashSet<string> classs = new HashSet<string>();

            foreach (Product product in store.Products.Keys)
            {
                classs.Add(product.ClassofProduct.Trim());
            }

            return classs;
        }
        public HashSet<string> getCategories(string classofprod) {
            Store store = Store.getInstance();
            HashSet<string> categories = new HashSet<string>();

            foreach (Product product in store.Products.Keys)
            {   
                if(product.ClassofProduct == classofprod)
                categories.Add(product.Category.Trim());
            }

            return categories;
        }

        public HashSet<string> getTypes(string category)
        {
            Store store = Store.getInstance();
            HashSet<string> types = new HashSet<string>();

            foreach (Product product in store.Products.Keys)
            {   
                if(product.Category == category)
                types.Add(product.Type.Trim());
            }

            return types;
        }
        public HashSet<string> getNames(string type)
        {
            Store store = Store.getInstance();
            HashSet<string> names = new HashSet<string>();

            foreach (Product product in store.Products.Keys)
            {   
                if (product.Type == type)
                names.Add(product.Name.Trim());
            }

            return names;
        }
        public bool isExistId(int id)
        {
            ClientOrderList orders =ClientOrderList.getInstance();
            foreach (ClientOrder order in orders.Orders)
            {
                if (order.getId() == id)
                {
                    return true;
                }                
            }
            return false;
        }


    }
}

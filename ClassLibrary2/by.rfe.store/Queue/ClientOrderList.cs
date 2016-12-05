using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.by.rfe.store.Entity;

namespace ClassLibrary.by.rfe.store.Queue
{
    public class ClientOrderList // Хранилище заказов клиентов
    {
        private static ClientOrderList instance = new ClientOrderList();
        private List<ClientOrder> orders = new List<ClientOrder>();

        private ClientOrderList()
        {

            orders.Add(new ClientOrder(1,
                new Product("class1", "cat1", "type1", "name1"),
                5, "Client1", "Minsk azaza", true, 0, 18));
            orders.Add(new ClientOrder(2,
                new Product("class2", "cat2", "type2", "name2"),
                10, "Client2", "Minsk azaza2", true, 0, 20));
            orders.Add(new ClientOrder(3,
                new Product("class3", "cat3", "type3", "name3"),
                15, "Client3", "Minsk azaza3", true, 0, 30));
            orders.Add(new ClientOrder(4,
                new Product("class4", "cat4", "type4", "name4"),
                7, "Client4", "Minsk azaza", true, 0, 12));
            orders.Add(new ClientOrder(5,
                new Product("class5", "cat5", "type5", "name5"),
                3, "Client6", "Minsk azaza5", true, 0, 14));


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




        public static ClientOrderList getInstance()
        {
            return instance;
        }

    }
}

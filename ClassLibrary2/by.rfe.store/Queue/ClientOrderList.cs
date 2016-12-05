﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.by.rfe.store.Entity;

namespace ClassLibrary.by.rfe.store.Queue
{
   public class ClientOrderList // Хранилище заказов клиентов
    {
        private static ClientOrderList instance  = new ClientOrderList();
        private List<ClientOrder> orders = new List<ClientOrder>();

        private ClientOrderList()
        {
            orders.Add(new ClientOrder(1, 5, false, "Client1", "Minsk azaza", true,0));

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

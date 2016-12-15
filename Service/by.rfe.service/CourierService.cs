using ClassLibrary.by.rfe.store.Entity;
using ClassLibrary.by.rfe.store.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.by.rfe.service
{
    public class CourierService
    {
        private static CourierService INSTANCE = new CourierService();

        private CourierService() { }
        public static CourierService INSTANCE1
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
                if (order.IsReady && !order.IsOnWay)
                    orders.Add(order);
            }
            return orders;
        }
        public void takeOrder(ClientOrder order)
        {
            order.IsOnWay = true;
        }
        public List<ClientOrder> getCourierList()
        {
            List<ClientOrder> orders = new List<ClientOrder>();
            foreach (ClientOrder order in ClientOrderList.getInstance().Orders)
            {
                if (order.IsOnWay && !order.IsDelivered)
                    orders.Add(order);
            }
            return orders;
        }
        public void giveOrder(ClientOrder order)
        {
            order.IsDelivered = true; 
        }

    }
}

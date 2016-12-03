using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.by.rfe.store.Entity
{
  public class Order
    {
        private int id;
        private int quantity;
        private bool isPayed;

        public Order(int id, int quantity, bool isPayed)
        {
            this.id = id;
            this.quantity = quantity;
            this.isPayed = isPayed;
        }
        public int getId()
        {
            return this.id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public int getQuantity()
        {
            return this.quantity;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public bool getPayed()
        {
            return this.isPayed;
        }
        public void setPayed(bool payed)
        {
            this.isPayed = payed;
        }

    }
}

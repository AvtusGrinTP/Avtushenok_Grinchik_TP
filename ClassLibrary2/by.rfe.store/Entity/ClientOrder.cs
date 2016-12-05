using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.by.rfe.store.Entity
{
   public class ClientOrder : Order
    {
        private string client;
        private string address;
        private bool isFull;
        private int countToEnd;

        public ClientOrder(int id, Product product, int quantity, bool isPayed,string client, string address, bool isFull, int countToEnd) : base(id, product, quantity, isPayed)
        {
            this.address = address;
            this.client = client;
            this.isFull = isFull;
            this.countToEnd = countToEnd;
        }
        public string getCLient()
        {
            return this.client;
        }
        public void setClient(string client)
        {
            this.client = client;
        }
        public string getAddress()
        {
            return this.address;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public bool getIsFull()
        {
            return this.isFull;
        }
        public void set(bool isFull)
        {
            this.isFull = isFull;
        }
        public int getCountToEnd()
        {
            return this.countToEnd;
        }
        public void setCountToEnd(int countToEnd)
        {
            this.countToEnd = countToEnd;
        }

        public override string ToString()
        {
            return getId().ToString() +"                | " + getCLient().ToString() + "| " + getQuantity().ToString() + "| " + getCountToEnd().ToString(); 
        }
    }
}

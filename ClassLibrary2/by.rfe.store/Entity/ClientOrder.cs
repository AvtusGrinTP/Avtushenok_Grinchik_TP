using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.by.rfe.store.Entity
{
    public class ClientOrder : Order
    {
        private string whoseOrder;
        private bool inBookmaker;
        private string client;
        private string address;
        private bool isFull;
        private int countToEnd;

        public ClientOrder(int id, string whoseOrder, bool inBookmaker, Product product, int quantity, string client, string address, bool isFull, int countToEnd, double price) : base(id, product, quantity, price)
        {
            this.whoseOrder = whoseOrder;
            this.inBookmaker = inBookmaker;
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
        public string getWhoseOrder
        {
            get
            {
                return whoseOrder;
            }
            set
            {
                whoseOrder = value;
            }
        }
        public bool isInBookmaker
        {
            get
            {
                return inBookmaker;
            }
            set
            {
                inBookmaker = value;
            }
        }
        public override string ToString()
        {
            int N1 = 9, N2 = 14, N3 = 9, N4 = 10;
            string Out;

            N1 -= getId().ToString().Length;
            Out = getId().ToString();
            Out = Space(Out, N1);

            N2 -= getCLient().ToString().Length;
            Out += getCLient();
            Out = Space(Out, N2);

            N3 -= getQuantity().ToString().Length;
            Out += getQuantity().ToString();
            Out = Space(Out, N3);

            N4 -= getCountToEnd().ToString().Length;
            Out += getCountToEnd().ToString();
            Out = Space(Out, N4);

            return Out;
        }

        public string Space(string Out, int N)
        {
            for (int i = 0; i < N; i++)
                Out += " ";

            return Out + "| ";
        }
    }
}

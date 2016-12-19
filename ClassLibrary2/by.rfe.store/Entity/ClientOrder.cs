﻿using System;
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
        private bool isReady;
        private bool isOnWay;
        private bool isDelivered;
        private bool inErrorList;
        private bool isDenied;
        

        public ClientOrder(int id,  Product product, int quantity, string client, string address, bool isFull, int countToEnd, double price) : base(id, product, quantity, price)
        {
            isDenied = false;
            inErrorList = false;
            isDelivered = false;
            isOnWay = false;
            isReady = false;
            this.address = address;
            this.client = client;
            this.isFull = isFull;
            this.countToEnd = countToEnd;
        }
        public ClientOrder() { }
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
        public bool IsReady
        {
            get
            {
                return isReady;
            }

            set
            {
                isReady = value;
            }
        }

        public bool IsOnWay
        {
            get
            {
                return isOnWay;
            }

            set
            {
                isOnWay = value;
            }
        }

        public bool IsDelivered
        {
            get
            {
                return isDelivered;
            }

            set
            {
                isDelivered = value;
            }
        }

        public bool InErrorList
        {
            get
            {
                return inErrorList;
            }

            set
            {
                inErrorList = value;
            }
        }

        public bool IsDenied
        {
            get
            {
                return isDenied;
            }

            set
            {
                isDenied = value;
            }
        }

        public override string ToString()
        {
            int N1 = 9, N2 = 14, N3 = 9, N4 = 10, N5 = 15;
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

            N5 -= getStatus().Length;
            Out += getStatus();
            Out = Space(Out, N5);

            return Out;
        }

        public string Space(string Out, int N)
        {
            for (int i = 0; i < N; i++)
                Out += " ";

            return Out + "| ";
        }

        public string getStatus()
        {
            if (!isFull)
                return "не хватает на складе";
            if (!getPayed() && isFull)
                return "ожидает оплаты";
            if (getPayed() && !isReady)
                return "ожидает сборки";
            if (isReady && !IsOnWay)
                return "ожидает курьера";
            if (IsOnWay && !IsDelivered && !InErrorList && !isDenied)
                return "в пути";
            if (IsDelivered && !InErrorList && !isDenied)
                return "доставлено";
            if (InErrorList && !IsDenied)
                return "пересборка";
            if (IsDenied)
                return "заказ отклонен";
            return "";
               
        }
    }
}

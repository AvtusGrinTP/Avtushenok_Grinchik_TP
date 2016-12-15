using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.by.rfe.store.Entity;

namespace ClassLibrary.by.rfe.store.Entity
{
   public class ProviderOrder : Order
    {
        private Provider provider;
        private ClientOrder clientOrder;
    
        public ProviderOrder(int id, Product product, int quantity, double price) : base(id, product, quantity, price)
        {
           
        }

        public ProviderOrder() { }
        public Provider Provider
        {
            get
            {
                return provider;
            }

            set
            {
                provider = value;
            }

           
        }

        public ClientOrder ClientOrder
        {
            get
            {
                return clientOrder;
            }

            set
            {
                clientOrder = value;
            }
        }

        public override string ToString()
        {
            int N1 = 9, N2 = 42, N3 = 11;
            string Out;

            N1 -= getId().ToString().Length;
            Out = getId().ToString();
            Out = Space(Out, N1, true);

            N2 -= Product.Name.ToString().Length;
            Out += Product.Name;
            Out = Space(Out, N2, true);

            N3 -= getQuantity().ToString().Length;
            Out += getQuantity().ToString();
            Out = Space(Out, N3, false);
            //почему телефон null???
            //          N4 -= Provider.PhoneNumber.ToString().Length;
            //          Out += Provider.PhoneNumber.ToString();
          //  Out = Space(Out, N4, false);

            return Out;
        }
        public string Space(string Out, int N, bool flag)
        {
            for (int i = 0; i < N; i++)
                Out += " ";

            if (flag)
                return Out + "| ";
            else return Out;
        }
    }
}


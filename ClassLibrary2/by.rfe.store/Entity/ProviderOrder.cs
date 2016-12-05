using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.by.rfe.store.Entity
{
   public class ProviderOrder : Order
    {
        private Provider provider;

        public ProviderOrder(int id, Product product, int quantity, double price) : base(id, product, quantity, price)
        {
            
                   
        }

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
        public override string ToString()
        {
            return getId() + " " + Product.Name + " " + getQuantity();
        }
    }
}


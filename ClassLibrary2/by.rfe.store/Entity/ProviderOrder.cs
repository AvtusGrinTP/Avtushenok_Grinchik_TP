﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.by.rfe.store.Entity
{
   public class ProviderOrder : Order
    {
        private Provider provider;

        public ProviderOrder(int id, int quantity, bool isPayed) : base(id, quantity, isPayed)
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
    }
}

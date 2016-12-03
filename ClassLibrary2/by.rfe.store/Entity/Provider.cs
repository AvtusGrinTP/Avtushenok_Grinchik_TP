using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.by.rfe.store
{
 public class Provider
    {
        private string name;
        private string phoneNumber;
        private string address;

        public Provider(string name, string phoneNumber, string address)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}

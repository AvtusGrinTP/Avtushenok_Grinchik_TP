using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.by.rfe.store.Entity
{
  public class Product
    {
        private string classofProduct;
        private string category;
        private string type;
        private string name;
        private double price;

        public Product(string classofpr, string category, string type, string name, double price)
        {
            this.classofProduct = classofpr;
            this.category = category;
            this.type = type;
            this.name = name;
            this.price = price;
        }

        public string ClassofProduct
        {
            get
            {
                return classofProduct;
            }

            set
            {
                classofProduct = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
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

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}

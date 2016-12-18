using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.by.rfe.store.Entity;

namespace TP
{
    public partial class StoreProductList : Form
    {
        //будем в списке отображать объект класса Product?
        private Product currentProduct;
        public StoreProductList(string service)
        {
            InitializeComponent();
            Text = service;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Form add = new ProductInf(Text, 1);
            add.ShowDialog();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orderString = listBox2.GetItemText(listBox2.SelectedItem);

            if (!orderString.Equals(""))
            {
                //поиск по скаду через Сервис Поставщика выбранного товара
                //foreach (Product order in ProviderOrderList.getInstance().Orders)
                //{
                //    if (orderString.Split('|')[0].Trim().Equals())
                //    {
                //        currentProduct = ;
                //        break;
                //    }
                //}
            }
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            Form edit = new ProductInf(Text, 2);
            edit.ShowDialog();
        }
    }
}

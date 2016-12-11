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
using Service.by.rfe.service;

namespace TP
{
    public partial class BookmakerInfProviderOrder : Form
    {
        private ProviderOrder currentOrder;
        public BookmakerInfProviderOrder(ProviderOrder currentOrder, string service)
        {
            InitializeComponent();
            this.currentOrder = currentOrder;
            textBox1.Text = currentOrder.getId().ToString();
            textBox2.Text = currentOrder.Product.ClassofProduct;
            textBox3.Text = currentOrder.Product.Category;
            textBox4.Text = currentOrder.Product.Type;
            textBox5.Text = currentOrder.Product.Name;
            textBox6.Text = currentOrder.getQuantity().ToString();
            textBox7.Text = currentOrder.Provider.Name;
            textBox8.Text = currentOrder.Provider.PhoneNumber;
            textBox9.Text = currentOrder.Price.ToString();
            Text = service;
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            BookmakerService.getInstance.pay(currentOrder);
            Form confirm = new DialogWithOne_Buttom("Оплата подтверждена", Text);
            confirm.ShowDialog();
            Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

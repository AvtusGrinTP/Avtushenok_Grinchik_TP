using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.by.rfe.store.Queue;
using ClassLibrary.by.rfe.store.Entity;

namespace TP
{
    public partial class EditOrder : Form
    {
       // private ClientOrder currentOrder;
        public EditOrder(ClientOrder currentOrder, string service/* ,int id, string classofProduct, string category, string type, string name, int quantity, string client, string addres*/)
        {
            InitializeComponent();
        //    this.currentOrder = currentOrder; 
            textBox3.Text = currentOrder.getId().ToString();
            comboBox1.Text = currentOrder.Product.ClassofProduct;
            comboBox2.Text = currentOrder.Product.Category;
            comboBox3.Text = currentOrder.Product.Type;
            textBox1.Text = currentOrder.Product.Name;
            textBox2.Text = currentOrder.getQuantity().ToString();
            textBox4.Text = currentOrder.getCLient();
            textBox5.Text = currentOrder.getAddress();
            Text = service;
        }
        private void editbutton_Click(object sender, EventArgs e)
        {
            Form editOrder = new DialogWithOne_Buttom("Заказ изменён", Text);
            editOrder.ShowDialog();

            Close();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            //        ClientOrderList.getInstance()
            //currentOrder = null;

            Form deleteOrder = new DialogWithOne_Buttom("Заказ удален", Text);
            deleteOrder.ShowDialog();

            Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}

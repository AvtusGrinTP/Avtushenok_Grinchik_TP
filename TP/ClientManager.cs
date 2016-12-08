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
using ClassLibrary.by.rfe.store.Queue;


namespace TP
{
    public partial class ClientManager : Form
    {

        private ClientOrder currentOrder;
        public ClientManager()
        {
            InitializeComponent();
            refresh();
        }

        public void refresh()
        {
            listBox1.Items.Clear();
            foreach (ClientOrder order in ClientOrderList.getInstance().Orders)
            {
                listBox1.Items.Add(order.ToString());
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Form addNew = new AddNewOrder(Text);
            addNew.ShowDialog();
            refresh();
        }

        /*
        private void editbutton_Click(object sender, EventArgs e)
        {
           if (listBox1.SelectedIndex == -1)
            {
                Form err = new DialogWithOne_Buttom("Выберите Заказ", Text);
               err.ShowDialog();
            }
           else
            {
                Form editOrder = new EditOrder(Text);
                editOrder.ShowDialog();
            }
        }
        */
        /*
        private void statusbutton_Click(object sender, EventArgs e)
        {
            string status = "status";

            Form dialog = new DialogWithOne_Buttom(status, Text);
            dialog.ShowDialog();
        }
        */
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  listBox1.Items.Add(new DialogWithOne_Buttom("status", Text));
            //  currentOrder = new ClientOrder();
            string orderString = listBox1.GetItemText(listBox1.SelectedItem);

            if (!orderString.Equals(""))
            {
                foreach(ClientOrder order in ClientOrderList.getInstance().Orders)
                {
                    if (orderString.Split('|')[1].Trim().Equals(order.getCLient()))
                    {
                        currentOrder = order;
                        break;
                    }
                }
            }


        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //string classofProduct = currentOrder.Product.ClassofProduct,
            //    category = currentOrder.Product.Category,
            //    type = currentOrder.Product.Type,
            //    name = currentOrder.Product.Name,
            //    client = currentOrder.getCLient(),
            //    addres = currentOrder.getAddress();
            //int id = currentOrder.getId(),
            //    quantity = currentOrder.getQuantity();
            Form editOrder = new EditOrder(currentOrder, Text);
            editOrder.ShowDialog();
        }

        
    }
}

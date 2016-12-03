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
          
        }

        public void refresh()
        {
            listBox1.Items.Clear();
            foreach (ClientOrderList product in ClientOrderList.getInstance().Orders)
            {
       //         listBox1.Items.Add(ClientOrder);
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Form addNew = new AddNewOrder(Text);
            addNew.ShowDialog();
        }

        

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

        private void statusbutton_Click(object sender, EventArgs e)
        {
            string status = "status";

            Form dialog = new DialogWithOne_Buttom(status, Text);
            dialog.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(new DialogWithOne_Buttom("status", Text));
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Form editOrder = new EditOrder(Text);
            editOrder.ShowDialog();
        }
    }
}

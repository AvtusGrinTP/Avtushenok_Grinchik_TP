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
using Service.by.rfe.service;


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
            textBox1.Text = "Поиск";
            textBox1.ForeColor = Color.Gray;
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  listBox1.Items.Add(new DialogWithOne_Buttom("status", Text));
            //  currentOrder = new ClientOrder();
            string orderString = listBox1.GetItemText(listBox1.SelectedItem);

            if (!orderString.Equals(""))
            {
                foreach (ClientOrder order in ClientOrderList.getInstance().Orders)
                {
                    if (orderString.Split('|')[0].Trim().Equals(order.getId().ToString()))//чувак, я тут переписал селект берем по id  а не по клиенту
                    {
                        currentOrder = order;
                        break;
                    }
                }
            }


        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Form editOrder = new EditOrder(currentOrder, Text);
            editOrder.ShowDialog();
           // refresh();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.Black;

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                string outPut = ClientManagerService.getInstance().showFindOrder(textBox1.Text);
                if (outPut != null)
                {
                    listBox1.Items.Clear();
                    string[] order = outPut.Split('/');
                    for (int i = 0; i < order.Length - 1; i++)
                        listBox1.Items.Add(order[i]);
                }
                else
                {
                    Form err = new DialogWithOne_Buttom("Проверте запрос на поиск",Text);
                    err.ShowDialog();
                }
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}

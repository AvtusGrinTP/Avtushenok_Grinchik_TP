using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class StoreKeeper : Form
    {
        string service = "StoreKeeper Service";
        object currentProduct; //!!!!!
        public StoreKeeper()
        {
            InitializeComponent();
            timerOrder.Enabled = true;
            timerOrder.Start();

          //  currentProduct = listBox1.Items;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {

            if (currentProduct == null)
            {
                Form mesError = new DialogWithOne_Buttom("Выбирете товар", service);
                mesError.ShowDialog();
            }
            else
            {

                listBox2.Items.Add(currentProduct);
                listBox1.Items.Remove(currentProduct);
                currentProduct = null;
                string message = "Товар добавлен в ********* список";
  
                Form add = new DialogWithOne_Buttom(message, service);
                add.ShowDialog();
            }
        }

        private void courierbutton2_Click(object sender, EventArgs e)
        {
            string message = "courier";

            DialogWithOne_Buttom couirier = new DialogWithOne_Buttom(message, service);
            couirier.ShowDialog();
        }

        private void storebutton_Click(object sender, EventArgs e)
        {
            string message = "store";

            DialogWithOne_Buttom store = new DialogWithOne_Buttom(message, service);
            store.ShowDialog();
        }

        private void courierbutton4_Click(object sender, EventArgs e)
        {
            string message = "courier";

            DialogWithOne_Buttom couirier = new DialogWithOne_Buttom(message, service);
            couirier.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //каждые 10 сек будет добавляться в спісок заказов
           // listBox1.Items.Add("100");
           // listBox4.Items.Add("Err");
        }

        
    }
}

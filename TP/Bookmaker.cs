using ClassLibrary.by.rfe.store.Entity;
using Service.by.rfe.service;
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
    public partial class Bookmaker : Form
    {
        string service = "Bookmaker Service";
        private ClientOrder currentOrder;
        public Bookmaker()
        {
            InitializeComponent();
            refresh();
        }

        void refresh() {
            foreach (ClientOrder order in BookmakerService.INSTANCE1.getClientOrders())
                listBox2.Items.Add(order);
            foreach (ProviderOrder order in BookmakerService.INSTANCE1.getProviderOrders())
                listBox2.Items.Add(order);
        }
        //private void confirmClientbutton_Click(object sender, EventArgs e)
        //{
        //    string confirm = "Заказ оплачен Клиентом";

        //    DialogWithOne_Buttom confirmPayClient = new DialogWithOne_Buttom(confirm, service);
        //    confirmPayClient.ShowDialog();
        //}

        //private void confirmProviderbutton_Click(object sender, EventArgs e)
        //{
        //    string confirm = "Заказ оплачен";
        //    DialogWithOne_Buttom confirmPayProvider = new DialogWithOne_Buttom(confirm, service);
        //    confirmPayProvider.ShowDialog();
        //}

        

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            DialogWithOne_Buttom confirmPay = new DialogWithOne_Buttom("Подтвердить оплату", service);
            confirmPay.ShowDialog();
            //BookmakerService.INSTANCE1.pay(currentOrder); 
            refresh();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
         //   item.
           // listView1.Items.Add(new ListViewItem);
        }
    }
}

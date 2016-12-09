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
        public Bookmaker()
        {
            InitializeComponent();
            listBox2.Items.AddRange(new object[] {
            "123",
            "234",
            "345"});
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
        }

        
    }
}

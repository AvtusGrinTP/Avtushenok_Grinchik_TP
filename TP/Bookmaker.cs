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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void confirmClientbutton_Click(object sender, EventArgs e)
        {
            string confirm = "Заказ оплачен Клиентом";

            DialogWithOne_Buttom confirmPayClient = new DialogWithOne_Buttom(confirm, service);
            confirmPayClient.ShowDialog();
        }

        private void confirmProviderbutton_Click(object sender, EventArgs e)
        {
            string confirm = "Заказ оплачен";
            DialogWithOne_Buttom confirmPayProvider = new DialogWithOne_Buttom(confirm, service);
            confirmPayProvider.ShowDialog();
        }
    }
}

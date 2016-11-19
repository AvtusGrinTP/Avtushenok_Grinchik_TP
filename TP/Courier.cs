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
    public partial class Courier : Form
    {
        string service = "Courier Service";
        public Courier()
        {
            InitializeComponent();
        }

        private void addToDeliverbutton_Click(object sender, EventArgs e)
        {
            string message = "add";
            DialogWithOne_Buttom addToDeliverbutton = new DialogWithOne_Buttom(message, service);
            addToDeliverbutton.ShowDialog();
            //переносим в список доставки
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            string message = "congirm";
            DialogWithOne_Buttom confirm = new DialogWithOne_Buttom(message, service);
            confirm.ShowDialog();
            //код, чтобы удалить заказ со списка
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            string message = "cancel";
            DialogWithOne_Buttom cancel = new DialogWithOne_Buttom(message, service);
            cancel.ShowDialog();
            //код для возврата товара на склад
        }
    }
}

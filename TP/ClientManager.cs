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
    public partial class ClientManager : Form
    {
        string service = "Client Manager Service";
        object currentProduct;
        public ClientManager()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Form addNew = new AddNewOrder(service);
            addNew.ShowDialog();
        }

        private void listOrderBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editbutton_Click(object sender, EventArgs e)
        {
           if (currentProduct == null)
            {
                Form err = new DialogWithOne_Buttom("Выберите товар", service);
               err.ShowDialog();
            }
           else
            {
                Form editOrder = new EditOrder(service);
                editOrder.ShowDialog();
            }
        }

        private void statusbutton_Click(object sender, EventArgs e)
        {
            string status = "status";

            Form dialog = new DialogWithOne_Buttom(status, service);
            dialog.ShowDialog();
        }
    }
}

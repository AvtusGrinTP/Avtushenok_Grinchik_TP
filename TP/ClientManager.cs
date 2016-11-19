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
        public ClientManager()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            AddNewOrder addNew = new AddNewOrder();
            addNew.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listOrderBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            EditOrder editOrder = new EditOrder();
            editOrder.ShowDialog();
        }

        private void statusbutton_Click(object sender, EventArgs e)
        {
            string status = "status";

            DialogWithOne_Buttom dialog = new DialogWithOne_Buttom(status, service);
            dialog.ShowDialog();
        }
    }
}

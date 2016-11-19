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
        public StoreKeeper()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string message = "add";
            DialogWithOne_Buttom add = new DialogWithOne_Buttom(message, service);
            add.ShowDialog();
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
    }
}

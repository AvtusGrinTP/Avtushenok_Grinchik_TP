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
    public partial class ProviderManager : Form
    {
        public ProviderManager()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Form add = new MakeProviderOrder();
            add.ShowDialog();
        }

        private void addNewbutton_Click(object sender, EventArgs e)
        {
            Form addNew = new AddNewProviderOrder();
            addNew.ShowDialog();
        }

        private void listProviderbutton_Click(object sender, EventArgs e)
        {
            Form list = new ProviderList();
            list.ShowDialog();
        }
    }
}

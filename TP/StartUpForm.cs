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
    public partial class StartUpForm : Form
    {
        public StartUpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Form CM = new ClientManager();
                CM.Show();
            }
            if (checkBox2.Checked)
            {
                Form CM = new ProviderManager();
                CM.Show();
            }
            if (checkBox3.Checked)
            {
                Form CM = new Bookmaker();
                CM.Show();
            }
            if (checkBox4.Checked)
            {
                Form CM = new StoreKeeper();
                CM.Show();
            }
            if (checkBox5.Checked)
            {
                Form CM = new Courier();
                CM.Show();
            }


        }
    }
}

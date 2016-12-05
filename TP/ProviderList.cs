using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.by.rfe.store.Entity;

namespace TP
{
    public partial class ProviderList : Form
    {
        private Provider currentProvider;
        public ProviderList()
        {
            InitializeComponent();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string name = currentProvider.Name,
                adress = currentProvider.Address,
                phone = currentProvider.PhoneNumber;
            
            Form editProvider = new EditProvider(name, adress,phone);
            editProvider.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Form addProvider = new AddNewProvider();
            addProvider.ShowDialog();
        }
    }
}

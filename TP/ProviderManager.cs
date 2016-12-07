﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.by.rfe.store.Entity;
using Service.by.rfe.service;
using ClassLibrary.by.rfe.store.Queue;

namespace TP
{
    public partial class ProviderManager : Form
    {
        private ProviderOrder currentProviderOrder;
        public ProviderManager()
        {
            InitializeComponent();

            refresh();
        }
        public void refresh()
        {
            ProviderManagerService service = ProviderManagerService.getInstance();
            List<ProviderOrder> orders =service.getProviderOrders();
            listBox1.Items.Clear();
            foreach (ProviderOrder order in orders)
            {
                if(order.Provider == null)
                {
                    listBox1.Items.Add(order);
                }
            }
        }

        private void addNewbutton_Click(object sender, EventArgs e)
        {
            Form addNew = new AddNewProviderOrder();
            addNew.ShowDialog();
        }

        private void listProviderbutton_Click(object sender, EventArgs e)
        {
            Form list = new ProviderList(Text);
            list.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orderString = listBox1.GetItemText(listBox1.SelectedItem);

            if (!orderString.Equals(""))
            {
                foreach (ProviderOrder order in ProviderOrderList.getInstance().Orders)
                {
                    if (orderString.Split('|')[0].Trim().Equals(order.getId().ToString()))
                    {
                        currentProviderOrder = order;
                        break;
                    }
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Form add = new MakeProviderOrder(currentProviderOrder, Text);
            add.ShowDialog();
            refresh();
        }

       
    }
}

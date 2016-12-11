using ClassLibrary.by.rfe.store.Entity;
using Service.by.rfe.service;
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
        private ClientOrder currentClientOrder;
        private ProviderOrder currentProviderOrder;
        public Bookmaker()
        {
            InitializeComponent();
            timer.Enabled = true;
            timer.Start();
            refresh();
        }

        void refresh()
        {
            foreach (ClientOrder order in BookmakerService.getInstance.getClientOrders())
            {
                if (!order.isInBookmaker && !order.getPayed())
                {
                    int N1 = 9, N2 = 14, N3 = 25, N4 = 25;
                    string Out;
                    N1 -= order.getId().ToString().Length;
                    Out = order.getId().ToString();
                    Out = Space(Out, N1);

                    N2 -= order.getWhoseOrder.Length;
                    Out += order.getWhoseOrder;
                    Out = Space(Out, N2);

                    N3 -= order.getCLient().ToString().Length;
                    Out += order.getCLient();
                    Out = Space(Out, N3);

                    N4 -= order.Product.Name.Length;
                    Out += order.Product.Name;
                    Out = Space(Out, N4);

                    order.isInBookmaker = true;
                    listBox2.Items.Add(Out);
                }
            }

            foreach (ProviderOrder order in BookmakerService.getInstance.getProviderOrders())
            {
                if (!order.isInBookmaker)
                {
                    int N1 = 9, N2 = 14, N3 = 25, N4 = 25;
                    string Out;
                    N1 -= order.getId().ToString().Length;
                    Out = order.getId().ToString();
                    Out = Space(Out, N1);

                    N2 -= order.getWhoseOrder.Length;
                    Out += order.getWhoseOrder;
                    Out = Space(Out, N2);

                    N3 -= order.Provider.Name.Length;
                    Out += order.Provider.Name;
                    Out = Space(Out, N3);

                    N4 -= order.Product.Name.Length;
                    Out += order.Product.Name;
                    Out = Space(Out, N4);

                    order.isInBookmaker = true;
                    listBox2.Items.Add(Out);
                }
            }
        }

        public string Space(string Out, int N)
        {
            for (int i = 0; i < N; i++)
                Out += " ";

            return Out + "| ";
        }


        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if (currentClientOrder != null)
            {
                Form confirmPay = new BookmakerInfClientOrder(currentClientOrder, Text);
                confirmPay.ShowDialog();
            }
            if(currentProviderOrder!= null)
            {
                Form confirmPay = new BookmakerInfProviderOrder(currentProviderOrder, Text);
                confirmPay.ShowDialog();
            }
            refresh();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orderString = listBox2.GetItemText(listBox2.SelectedItem);

            if (!orderString.Equals(""))
            {
                foreach (ProviderOrder order in BookmakerService.getInstance.getProviderOrders())
                {
                    if (orderString.Split('|')[1].Trim().Equals(order.getWhoseOrder))
                    {
                        if (orderString.Split('|')[0].Trim().Equals(order.getId().ToString()))
                        {
                            currentProviderOrder = order;
                            break;
                        }

                    }
                }
                foreach (ClientOrder order in BookmakerService.getInstance.getClientOrders())
                {
                    if (orderString.Split('|')[1].Trim().Equals(order.getWhoseOrder))
                    {
                        if (orderString.Split('|')[0].Trim().Equals(order.getId().ToString()))
                        {
                            currentClientOrder = order;
                            break;
                        }

                    }
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            refresh();
        }


    }
}

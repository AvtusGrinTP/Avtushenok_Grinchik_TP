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
using Service.by.rfe.service;

namespace TP
{
    public partial class StoreKeeper : Form
    {
        private Order currentOrder;

        public StoreKeeper()
        {
            InitializeComponent();

            timerClient.Enabled = true;
            timerProvider.Enabled = true;
            timerError.Enabled = true;
            timerClient.Start();
            timerProvider.Start();
            timerError.Start();

            tabControl1.TabPages[3].Text = DateTime.Now.ToShortDateString();


            refreshClient();
            refreshProvider();
            refreshError();

        }

        private void refreshClient()
        {
            listBox4.Items.Clear();
              foreach (ClientOrder order in StoreKeeperService.INSTANCE1.getClientOrders())
            {

               int N1 = 9, N2 = 21, N3 = 40;
                string Out;
                N1 -= order.getId().ToString().Length;
                Out = order.getId().ToString();
                Out = Space(Out, N1);

                N2 -= order.getCLient().ToString().Length;
                Out += order.getCLient();
                Out = Space(Out, N2);

               N3 -= order.Product.Name.Length;
                Out += order.Product.Name;
                Out = Space(Out, N3);

                listBox4.Items.Add(Out);

            }
          

        }

        private void refreshProvider()
        {
            listBox6.Items.Clear();
            foreach (ProviderOrder order in StoreKeeperService.INSTANCE1.getProviderOrders())
            {

                int N1 = 9, N2 = 21, N3 = 40;
                string Out;
                N1 -= order.getId().ToString().Length;
                Out = order.getId().ToString();
                Out = Space(Out, N1);

                N2 -= order.Provider.Name.Length;
                Out += order.Provider.Name;
                Out = Space(Out, N2);

                N3 -= order.Product.Name.Length;
                Out += order.Product.Name;
                Out = Space(Out, N3);


                listBox6.Items.Add(Out);

            }
        }

        private void refreshError()
        {
            listBox8.Items.Clear();
        }

        public string Space(string Out, int N)
        {
            for (int i = 0; i < N; i++)
                Out += " ";

            return Out + "| ";
        }

        private void timerClient_Tick(object sender, EventArgs e)
        {
            int count0 = listBox4.Items.Count; //чтобы тестить ставь ==

            refreshClient(); //может сделать задержку?
            if ((count0 != listBox4.Items.Count)  && (-count0 + listBox4.Items.Count > 0))
            {
                string msg = "chek list! \nДобавлено " + (listBox4.Items.Count - count0).ToString() + " новых заказов";
                count0 = listBox4.Items.Count; 
                Form info = new DialogWithOne_Buttom(msg, Text);
                info.Show();
            }
        }

        private void timerProvider_Tick(object sender, EventArgs e)
        {
            int count0 = listBox4.Items.Count; //чтобы тестить ставь ==
            //  refreshProvider();
            if (count0 != listBox4.Items.Count)
            {
                string msg = "chek list! \nДобавлено " + (listBox4.Items.Count - count0).ToString() + " новых заказов";
                Form info = new DialogWithOne_Buttom(msg, Text);
                info.Show();
            }
        }

        private void timerError_Tick(object sender, EventArgs e)
        {
            // refreshError();
        }

        private void listBox4_DoubleClick(object sender, EventArgs e)
        {
            Form confirmPay = new BookmakerInfClientOrder((ClientOrder)currentOrder, Text, 2);
            confirmPay.ShowDialog();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orderString = listBox4.GetItemText(listBox4.SelectedItem);

            if (!orderString.Equals(""))
            {
                foreach (ClientOrder order in StoreKeeperService.INSTANCE1.getClientOrders())
                {

                    if (orderString.Split('|')[0].Trim().Equals(order.getId().ToString()))
                    {
                        currentOrder = order;
                        break;
                    }


                }
            }
        }

        private void listBox6_DoubleClick(object sender, EventArgs e)
        {

            Form confirmPay = new BookmakerInfProviderOrder((ProviderOrder)currentOrder, Text, 2);
            confirmPay.ShowDialog();

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orderString = listBox6.GetItemText(listBox6.SelectedItem);

            if (!orderString.Equals(""))
            {
                foreach (ProviderOrder order in StoreKeeperService.INSTANCE1.getProviderOrders())
                {
                    if (orderString.Split('|')[0].Trim().Equals(order.getId().ToString()))
                    {
                        currentOrder = order;
                        break;
                    }
                }
            }
        }

        private void listBox8_DoubleClick(object sender, EventArgs e)
        {
            Form confirmPay = new BookmakerInfClientOrder((ClientOrder)currentOrder, Text, 2);
            confirmPay.ShowDialog();
        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orderString = listBox4.GetItemText(listBox4.SelectedItem);

            //if (!orderString.Equals(""))
            //{
            //    foreach (ClientOrder order in )
            //    {

            //        if (orderString.Split('|')[0].Trim().Equals(order.getId().ToString()))
            //        {
            //            currentOrder = order;
            //            break;
            //        }


            //    }
            //}
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = e.TabPageIndex == 3;
        }

        //не удаляй, пусть висит тут
        //private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        //{

        //    Graphics g = e.Graphics;
        //    //TabPage tp = tabControl1.TabPages[0];

        //    StringFormat sf = new StringFormat();
        //    sf.Alignment = StringAlignment.Center;  //optional

        //    // This is the rectangle to draw "over" the tabpage title
        //    RectangleF headerRect = new RectangleF(e.Bounds.X-5, e.Bounds.Y+2, e.Bounds.Width + 10, e.Bounds.Height+4);

        //    // This is the default colour to use for the non-selected tabs
        //    //           SolidBrush sb = new SolidBrush(Color.WhiteSmoke);

        //    // This changes the colour if we're trying to draw the selected tabpage
        //    // if (tabControl1.SelectedIndex == e.Index)
        //    //   sb.Color = Color.Aqua;

        //    // Colour the header of the current tabpage based on what we did above
        //    //g.FillRectangle(sb, e.Bounds);

        //    //Remember to redraw the text - I'm always using black for title text
        //    if (newOrder()/* && tabControl1.TabPages[0].Text == orderList.Text*/)
        //    {
        //        g.DrawString(tabControl1.TabPages[e.Index].Text, tabControl1.Font, new SolidBrush(Color.Red), headerRect, sf);
        //    }
        //    else if(newErrorOrder() /*&& /*tabControl1.TabPages[3].Text == errorList.Text*/)
        //    {
        //        g.DrawString(tabControl1.TabPages[e.Index].Text, tabControl1.Font, new SolidBrush(Color.Red), headerRect, sf);

        //    }
        //    else
        //    {
        //        g.DrawString(tabControl1.TabPages[e.Index].Text, tabControl1.Font, new SolidBrush(Color.Black), headerRect, sf);
        //        g.DrawString(tabControl1.TabPages[e.Index].Text, tabControl1.Font, new SolidBrush(Color.Black), headerRect, sf);

        //    }
        //}


    }
}

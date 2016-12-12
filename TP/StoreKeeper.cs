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
    public partial class StoreKeeper : Form
    {
        string service = "StoreKeeper Service";
        object currentProduct; //!!!!!
        public StoreKeeper()
        {
            InitializeComponent();
          //  timerOrder.Enabled = true;
          //  timerError.Enabled = true;
            timerOrder.Start();
            timerError.Start();

            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;

            //в будем

          //  currentProduct = listBox1.Items;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {

            if (currentProduct == null)
            {
                Form mesError = new DialogWithOne_Buttom("Выбирете товар", service);
                mesError.ShowDialog();
            }
            else
            {

                listBox2.Items.Add(currentProduct);
                listBox1.Items.Remove(currentProduct);
                currentProduct = null;
                string message = "Товар добавлен в ********* список";
  
                Form add = new DialogWithOne_Buttom(message, service);
                add.ShowDialog();
            }
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

        private void timerOrder_Tick(object sender, EventArgs e)
        {
            //каждые 10 сек будет добавляться в спісок заказов
            listBox1.Items.Add("100");
           

        }
        //делаем рефреш на два списка
        //и каждому даем булевскую функцию, чтобы следить за добавлением новых элементов
        private void refreshOrder()
        {
            listBox1.Items.Clear();
            //foreach(ClientOrder order in Service)
            {

            }
        }
        private bool newOrder()
        {
            int count0 = listBox1.Items.Count;
         //   refreshOrder();
            if(count0 != listBox1.Items.Count)
            {
                return true;
            }
            return false;
        }
        private void timerError_Tick(object sender, EventArgs e)
        {
            listBox8.Items.Add("100000");

        }

        private bool newErrorOrder()
        {
            int count0 = listBox8.Items.Count;
            refreshOrder();
            if (count0 == listBox8.Items.Count)
            {
                return true;
            }
            return false;
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

            Graphics g = e.Graphics;
            //TabPage tp = tabControl1.TabPages[0];

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;  //optional

            // This is the rectangle to draw "over" the tabpage title
            RectangleF headerRect = new RectangleF(e.Bounds.X-5, e.Bounds.Y+2, e.Bounds.Width + 10, e.Bounds.Height+4);

            // This is the default colour to use for the non-selected tabs
            //           SolidBrush sb = new SolidBrush(Color.WhiteSmoke);

            // This changes the colour if we're trying to draw the selected tabpage
            // if (tabControl1.SelectedIndex == e.Index)
            //   sb.Color = Color.Aqua;

            // Colour the header of the current tabpage based on what we did above
            //g.FillRectangle(sb, e.Bounds);

            //Remember to redraw the text - I'm always using black for title text
            if (newOrder()/* && tabControl1.TabPages[0].Text == orderList.Text*/)
            {
                g.DrawString(tabControl1.TabPages[e.Index].Text, tabControl1.Font, new SolidBrush(Color.Red), headerRect, sf);
            }
            else if(newErrorOrder() /*&& /*tabControl1.TabPages[3].Text == errorList.Text*/)
            {
                g.DrawString(tabControl1.TabPages[e.Index].Text, tabControl1.Font, new SolidBrush(Color.Red), headerRect, sf);

            }
            else
            {
                g.DrawString(tabControl1.TabPages[e.Index].Text, tabControl1.Font, new SolidBrush(Color.Black), headerRect, sf);
                g.DrawString(tabControl1.TabPages[e.Index].Text, tabControl1.Font, new SolidBrush(Color.Black), headerRect, sf);

            }
        }

       
    }
}

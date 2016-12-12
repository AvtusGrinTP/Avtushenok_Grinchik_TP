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
    public partial class Courier : Form
    {
        string service = "Courier Service";
        public Courier()
        {
            InitializeComponent();
            timer.Enabled = true;
            timer.Start();

            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;

        }

        private void addToDeliverbutton_Click(object sender, EventArgs e)
        {
            string message = "add";
            DialogWithOne_Buttom addToDeliverbutton = new DialogWithOne_Buttom(message, service);
            addToDeliverbutton.ShowDialog();
            //переносим в список доставки
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            string message = "congirm";
            DialogWithOne_Buttom confirm = new DialogWithOne_Buttom(message, service);
            confirm.ShowDialog();
            //код, чтобы удалить заказ со списка
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            string message = "cancel";
            DialogWithOne_Buttom cancel = new DialogWithOne_Buttom(message, service);
            cancel.ShowDialog();
            //код для возврата товара на склад
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabPage tp = tabControl1.TabPages[e.Index];

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;  //optional

            // This is the rectangle to draw "over" the tabpage title
            RectangleF headerRect = new RectangleF(e.Bounds.X - 5, e.Bounds.Y + 2, e.Bounds.Width + 10, e.Bounds.Height + 4);

            // This is the default colour to use for the non-selected tabs
            SolidBrush sb = new SolidBrush(Color.WhiteSmoke);

            // This changes the colour if we're trying to draw the selected tabpage
            // if (tabControl1.SelectedIndex == e.Index)
            //   sb.Color = Color.Aqua;

            // Colour the header of the current tabpage based on what we did above
            g.FillRectangle(sb, e.Bounds);

            //Remember to redraw the text - I'm always using black for title text
            g.DrawString(tp.Text, tabControl1.Font, new SolidBrush(Color.Black), headerRect, sf);
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}

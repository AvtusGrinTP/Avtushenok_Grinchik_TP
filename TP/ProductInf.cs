using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//флаги
// 1 - добавление нового
// 2 - изменить текущий

namespace TP
{
    public partial class ProductInf : Form
    {
        private int fromWho;
        public ProductInf(string service, int fromWho)
        {
            InitializeComponent();
            Text = service;
            this.fromWho = fromWho;
            if(fromWho == 1)
            {
                button1.Text = "Добавить";
                button2.Visible = false;
            }
            if(fromWho == 2)
            {
                button1.Text = "Изменить";
                button2.Text = "Удалить";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(fromWho == 1)
            {
                //добавить новый товар
            }
            if(fromWho == 2)
            {
                //переписать введенные параметры
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //удалить со склада
        }
    }
}

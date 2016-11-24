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
    public partial class MakeProviderOrder : Form
    {
        string service = "Provider Manager Service";
        public MakeProviderOrder()
        {
            InitializeComponent();
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || comboBox1.Text.Equals(""))
            {
                Form err = new DialogWithOne_Buttom("Заполните все поля", service);
                err.ShowDialog();
            }
            else
            {
                try
                {

                    int number = int.Parse(textBox1.Text);
                    if (number < 1)
                    {
                        Form err = new DialogWithOne_Buttom("Номер заказа не может быть\n отрицательным либо равным нулю", service);
                        err.ShowDialog();
                    }
                    else
                    {
                        Form confirm = new DialogWithOne_Buttom("confirm", service);
                        confirm.ShowDialog();

                        Close();
                    }
                }
                catch (Exception)
                {
                    Form err = new DialogWithOne_Buttom("Номер заказа состоит только из цифр", Text);
                    err.ShowDialog();
                }
            }
            
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class AddNewProviderOrder : Form
    {
        public AddNewProviderOrder()
        {
            InitializeComponent();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createProviderOrderbutton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("") /*|| comboBox2.Text.Equals("") || comboBox3.Text.Equals("") || textBox1.Text.Equals("") || textBox3.Text.Equals("")*/)
            {
                Form err = new DialogWithOne_Buttom("Заполните все поля", Text);
                err.ShowDialog();
            }
            else
            {
                try
                {

                    int number = int.Parse(textBox2.Text);
                    double price = double.Parse(textBox3.Text);
                    if ((number < 1)|| (price < 1))
                    {
                        if (number < 1)
                        {
                            Form err = new DialogWithOne_Buttom("Количество не может быть \nотрицательным либо равным нулю", Text);
                            err.ShowDialog();
                        }

                        else
                        {
                            Form err = new DialogWithOne_Buttom("Цена не может быть \nотрицательной либо равной нулю", Text);
                            err.ShowDialog();
                        }
                    }
                    else
                    {
                        Form createOrder = new DialogWithOne_Buttom("Заказ оформлен", Text);
                        createOrder.ShowDialog();

                        Close();
                    }
                }
                catch (Exception)
                {
                        Form err = new DialogWithOne_Buttom("Количество состоит только из цифр", Text);
                        err.ShowDialog();
                    
                }
            }
        }
    }
}

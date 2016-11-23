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
    public partial class AddNewOrder : Form
    {
        public AddNewOrder(string service)
        {
            InitializeComponent();
            Text = service;
        }

        private void createOrderbutton_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text.Equals("") || comboBox2.Text.Equals("") || comboBox3.Text.Equals("") || textBox1.Text.Equals("") || textBox3.Text.Equals(""))
            {
                Form err = new DialogWithOne_Buttom("Заполните все поля", Text);
                err.ShowDialog();
            }
            else 
            {
                try
                {

                    int number = int.Parse(textBox3.Text);
                    if (number < 1)
                    {
                        Form err = new DialogWithOne_Buttom("Количество не может быть \nотрицательным либо равным нулю", Text);
                        err.ShowDialog();
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


        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBox1.Text.Equals(comboBox1.Items[0]))
                {
                    comboBox2.Items.Add("a");
                }
                else if (comboBox1.Text.Equals(comboBox1.Items[1]))
                {
                    comboBox2.Items.Add("b");
                }
            }
            catch (Exception)
            {
                Form err = new DialogWithOne_Buttom("Выбирете Класс товара", Text);
                err.ShowDialog();
            }
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text.Equals(comboBox2.Items[0]))
                {
                    comboBox3.Items.Add("aa");
                }
                else if (comboBox2.Text.Equals(comboBox2.Items[1]))
                {
                    comboBox3.Items.Add("bb");
                }
            }
            catch (Exception)
            {
                Form err = new DialogWithOne_Buttom("Выбирете Категорию", Text);
                err.ShowDialog();
            }
        }
    }
}

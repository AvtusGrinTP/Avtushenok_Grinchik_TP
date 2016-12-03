using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.by.rfe.store.Queue;
using ClassLibrary.by.rfe.store.Entity;

namespace TP
{
    public partial class AddNewOrder : Form
    {
        public AddNewOrder(string service)
        {
            InitializeComponent();
            Text = service;

            comboBox1.Items.AddRange(new string[] {
            "Продовольственные товары",
            "Промышленные товары"});

            //comboBox2.Items.AddRange(new string[] {
            //"Категория 1",
            //"Категория 2"});
            comboBox2.Enabled = false;

            //comboBox3.Items.AddRange(new string[] {
            //"Тип 1",
            //"Тип 2"});
            comboBox3.Enabled = false;

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

                    //    ClientOrderList.addClientOrder();
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
            if (comboBox1.Text.Equals("Продовольственные товары"))
            {
                //            comboBox3.Items[0].;
               // comboBox2.Items[1].Remove 
            }
            else 
            {
                comboBox2.Items.Add("bb");
            }
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            
                
           
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!comboBox1.Text.Equals(""))
            {
                comboBox2.Enabled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox2.Text.Equals(""))
            {
                comboBox3.Enabled = true;
            }
        }
    }
}

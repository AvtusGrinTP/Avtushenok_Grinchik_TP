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
    public partial class EditProvider : Form
    {
        public EditProvider()
        {
            InitializeComponent();
        }
        public EditProvider(string name, string adress, string phone)
        {
            InitializeComponent();
            textBox1.Text = name;
            textBox2.Text = adress;
            textBox3.Text = phone;

        }
        private void editbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Equals("")||textBox2.Text.Equals("")||textBox3.Equals(""))
            {
                Form err = new DialogWithOne_Buttom("Заполните все поля", Text);
                err.ShowDialog();
            }
            else
            {
                try
                {
                    int number = int.Parse(textBox3.Text);
                    if (textBox3.TextLength == 12)
                    {
                        Form createProvider = new DialogWithOne_Buttom("Поставщик добавлен", Text);
                        createProvider.ShowDialog();

                        Close();
                    }
                    else
                    {
                        Form err = new DialogWithOne_Buttom("Длина номера должна состоять из 12 цифр", Text);
                        err.ShowDialog();
                    }
                }
                catch (Exception)
                {
                    Form err = new DialogWithOne_Buttom("Номер состоит только из цифр", Text);
                    err.ShowDialog();
                }
            }
        }
    }
}

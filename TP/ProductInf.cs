using Entity.entity;
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
//флаги
// 1 - добавление нового
// 2 - изменить текущий

namespace TP                                                                            
{
    public partial class ProductInf : Form
    {
        private Product product = null;
        private int fromWho;
        public ProductInf(string service, int fromWho)  //конструктор для добавления нового товара
        {
            InitializeComponent();
            Text = service;

            this.fromWho = fromWho;

            refreshClass();
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;


            button1.Text = "Добавить";
            button2.Visible = false;
            textBox5.Enabled = false;
            comboBox5.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Text = DateTime.Parse("01.01.2000").ToString();
        }

        public ProductInf(Product product, string service, int fromWho) //конструктор для изменения 
        {
            InitializeComponent();
            Text = service;

            this.product = product;
            this.fromWho = fromWho;

            refreshClass();
            comboBox1.Text = product.ClassofProduct;
            comboBox2.Text = product.Category;
            comboBox3.Text = product.Type;
            comboBox4.Text = product.Name;
            //как взять количество товаров?
            //  textBox5.Text = 

            foreach (Provider provider in ProviderManagerService.getInstance().ProviderList)
            {
                comboBox5.Items.Add(provider.Name);
            }

            //если изменять, то не знаю какие поля делать досупными
            button1.Text = "Изменить";
            button2.Text = "Удалить";
        }

        void refreshClass()
        {
            ClientManagerService clientManagerService = ClientManagerService.getInstance();
            HashSet<string> classs = clientManagerService.getClass();
            string[] cl = classs.ToArray<string>();
            comboBox1.Items.AddRange(cl);

        }
        void refreshCategory()
        {
            ClientManagerService clientManagerService = ClientManagerService.getInstance();
            HashSet<string> categories = clientManagerService.getCategories(comboBox1.Text);
            string[] cat = categories.ToArray<string>();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(cat);
        }

        void refreshType()
        {
            ClientManagerService clientManagerService = ClientManagerService.getInstance();
            HashSet<string> types = clientManagerService.getTypes(comboBox2.Text);
            string[] ty = types.ToArray<string>();
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(ty);
        }
        void refreshName()
        {
            ClientManagerService clientManagerService = ClientManagerService.getInstance();
            HashSet<string> names = clientManagerService.getNames(comboBox3.Text);
            string[] ty = names.ToArray<string>();
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(ty);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fromWho == 1)
            {
                //добавить новый товар
            }
            if (fromWho == 2)
            {
                //переписать введенные параметры
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //удалить со склада
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox1.Text.Equals(""))
            {
                refreshCategory();
                comboBox2.Enabled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox2.Text.Equals(""))
            {
                refreshType();
                comboBox3.Enabled = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox3.Text.Equals(""))
            {
                refreshName();
                comboBox4.Enabled = true;
            }
        }
    }
}

﻿using System;
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
// флаг fromWho чтобы определить кто вызывает эту форму
// 1 - bookmaker
// 2 - storekeeper
// 3 - courier


namespace TP
{
    public partial class BookmakerInfProviderOrder : Form
    {
        private ProviderOrder currentOrder;
        private int fromWho;

        public BookmakerInfProviderOrder(ProviderOrder currentOrder, string service, int fromWho)
        {
            InitializeComponent();
            this.currentOrder = currentOrder;
            textBox1.Text = currentOrder.getId().ToString();
            textBox2.Text = currentOrder.Product.ClassofProduct;
            textBox3.Text = currentOrder.Product.Category;
            textBox4.Text = currentOrder.Product.Type;
            textBox5.Text = currentOrder.Product.Name;
            textBox6.Text = currentOrder.getQuantity().ToString();
            textBox7.Text = currentOrder.Provider.Name;
            textBox8.Text = currentOrder.Provider.PhoneNumber;
            textBox9.Text = currentOrder.Price.ToString();
            Text = service;
            this.fromWho = fromWho;
            if (fromWho == 1)
            {
                button1.Text = "Подтвердить";
            }
            if (fromWho == 2)
            {
                button1.Text = "Добавить на склад";
            }
            if (fromWho == 3)
            {
                button1.Text = "Добавить в Доставки";
            }
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            if (fromWho == 1)
            {
                BookmakerService.getInstance.pay(currentOrder);
                Form confirm = new DialogWithOne_Buttom("Оплата подтверждена", Text);
                confirm.ShowDialog();
            }
            if (fromWho == 2)
            {
                StoreKeeperService.INSTANCE1.takeProviderOrder(currentOrder); 
                Form confirm = new DialogWithOne_Buttom("Заказ выполнен", Text);
                confirm.ShowDialog();
            }
            if (fromWho == 3)
            {
                Form confirm = new DialogWithOne_Buttom("Заказ добавлен в Доставки", Text);
                confirm.ShowDialog();
            }
            Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

namespace TP
{
    partial class StoreKeeper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.orderList = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.courierList = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.toStockList = new System.Windows.Forms.TabPage();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.errorList = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.orderList.SuspendLayout();
            this.courierList.SuspendLayout();
            this.toStockList.SuspendLayout();
            this.errorList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.orderList);
            this.tabControl1.Controls.Add(this.courierList);
            this.tabControl1.Controls.Add(this.toStockList);
            this.tabControl1.Controls.Add(this.errorList);
            this.tabControl1.Location = new System.Drawing.Point(-5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // orderList
            // 
            this.orderList.BackColor = System.Drawing.Color.Silver;
            this.orderList.Controls.Add(this.button1);
            this.orderList.Controls.Add(this.listBox1);
            this.orderList.Location = new System.Drawing.Point(4, 22);
            this.orderList.Name = "orderList";
            this.orderList.Padding = new System.Windows.Forms.Padding(3);
            this.orderList.Size = new System.Drawing.Size(705, 536);
            this.orderList.TabIndex = 0;
            this.orderList.Text = "Список заказов";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить в список";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(680, 446);
            this.listBox1.TabIndex = 1;
            // 
            // courierList
            // 
            this.courierList.BackColor = System.Drawing.Color.Silver;
            this.courierList.Controls.Add(this.button2);
            this.courierList.Controls.Add(this.listBox2);
            this.courierList.Location = new System.Drawing.Point(4, 22);
            this.courierList.Name = "courierList";
            this.courierList.Padding = new System.Windows.Forms.Padding(3);
            this.courierList.Size = new System.Drawing.Size(705, 536);
            this.courierList.TabIndex = 1;
            this.courierList.Text = "Список отправки";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отправить Курьеру";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.courierbutton2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(13, 6);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(680, 446);
            this.listBox2.TabIndex = 0;
            // 
            // toStockList
            // 
            this.toStockList.BackColor = System.Drawing.Color.Silver;
            this.toStockList.Controls.Add(this.listBox3);
            this.toStockList.Controls.Add(this.button3);
            this.toStockList.Location = new System.Drawing.Point(4, 22);
            this.toStockList.Name = "toStockList";
            this.toStockList.Size = new System.Drawing.Size(705, 536);
            this.toStockList.TabIndex = 2;
            this.toStockList.Text = "Список доставок";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(13, 6);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(680, 446);
            this.listBox3.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(275, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 50);
            this.button3.TabIndex = 0;
            this.button3.Text = "Добавить товар на склад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.storebutton_Click);
            // 
            // errorList
            // 
            this.errorList.BackColor = System.Drawing.Color.Silver;
            this.errorList.Controls.Add(this.button5);
            this.errorList.Controls.Add(this.listBox4);
            this.errorList.Location = new System.Drawing.Point(4, 22);
            this.errorList.Name = "errorList";
            this.errorList.Size = new System.Drawing.Size(705, 536);
            this.errorList.TabIndex = 3;
            this.errorList.Text = "Список ошибок";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(275, 474);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 50);
            this.button5.TabIndex = 2;
            this.button5.Text = "Отправить Курьеру";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.courierbutton4_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(13, 6);
            this.listBox4.Name = "listBox4";
            this.listBox4.ScrollAlwaysVisible = true;
            this.listBox4.Size = new System.Drawing.Size(680, 446);
            this.listBox4.TabIndex = 0;
            // 
            // StoreKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "StoreKeeper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Keeper Service";
            this.tabControl1.ResumeLayout(false);
            this.orderList.ResumeLayout(false);
            this.courierList.ResumeLayout(false);
            this.toStockList.ResumeLayout(false);
            this.errorList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage courierList;
        private System.Windows.Forms.TabPage toStockList;
        private System.Windows.Forms.TabPage errorList;
        private System.Windows.Forms.TabPage orderList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox4;
    }
}
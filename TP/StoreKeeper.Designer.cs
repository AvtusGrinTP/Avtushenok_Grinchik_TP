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
            this.components = new System.ComponentModel.Container();
            this.timerOrder = new System.Windows.Forms.Timer(this.components);
            this.errorList = new System.Windows.Forms.TabPage();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.toStockList = new System.Windows.Forms.TabPage();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.courierList = new System.Windows.Forms.TabPage();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.orderList = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timerError = new System.Windows.Forms.Timer(this.components);
            this.errorList.SuspendLayout();
            this.toStockList.SuspendLayout();
            this.courierList.SuspendLayout();
            this.orderList.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerOrder
            // 
            this.timerOrder.Enabled = true;
            this.timerOrder.Interval = 1000;
            this.timerOrder.Tick += new System.EventHandler(this.timerOrder_Tick);
            // 
            // errorList
            // 
            this.errorList.BackColor = System.Drawing.Color.Silver;
            this.errorList.Controls.Add(this.listBox8);
            this.errorList.Controls.Add(this.listBox7);
            this.errorList.Controls.Add(this.button5);
            this.errorList.Location = new System.Drawing.Point(4, 28);
            this.errorList.Name = "errorList";
            this.errorList.Size = new System.Drawing.Size(705, 530);
            this.errorList.TabIndex = 3;
            this.errorList.Tag = "3";
            this.errorList.Text = "Список ошибок";
            // 
            // listBox8
            // 
            this.listBox8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox8.FormattingEnabled = true;
            this.listBox8.ItemHeight = 19;
            this.listBox8.Location = new System.Drawing.Point(12, 30);
            this.listBox8.Name = "listBox8";
            this.listBox8.ScrollAlwaysVisible = true;
            this.listBox8.Size = new System.Drawing.Size(680, 422);
            this.listBox8.TabIndex = 4;
            // 
            // listBox7
            // 
            this.listBox7.Enabled = false;
            this.listBox7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 19;
            this.listBox7.Items.AddRange(new object[] {
            "??????????????????????????????"});
            this.listBox7.Location = new System.Drawing.Point(12, 7);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(680, 23);
            this.listBox7.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(285, 464);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 60);
            this.button5.TabIndex = 2;
            this.button5.Text = "Отправить Курьеру";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.courierbutton4_Click);
            // 
            // toStockList
            // 
            this.toStockList.BackColor = System.Drawing.Color.Silver;
            this.toStockList.Controls.Add(this.listBox6);
            this.toStockList.Controls.Add(this.listBox5);
            this.toStockList.Controls.Add(this.button3);
            this.toStockList.Location = new System.Drawing.Point(4, 28);
            this.toStockList.Name = "toStockList";
            this.toStockList.Size = new System.Drawing.Size(705, 530);
            this.toStockList.TabIndex = 2;
            this.toStockList.Tag = "2";
            this.toStockList.Text = "Список доставок";
            // 
            // listBox6
            // 
            this.listBox6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 19;
            this.listBox6.Location = new System.Drawing.Point(12, 30);
            this.listBox6.Name = "listBox6";
            this.listBox6.ScrollAlwaysVisible = true;
            this.listBox6.Size = new System.Drawing.Size(680, 422);
            this.listBox6.TabIndex = 2;
            // 
            // listBox5
            // 
            this.listBox5.Enabled = false;
            this.listBox5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 19;
            this.listBox5.Items.AddRange(new object[] {
            "??????????????????????????????"});
            this.listBox5.Location = new System.Drawing.Point(12, 7);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(680, 23);
            this.listBox5.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(285, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 60);
            this.button3.TabIndex = 0;
            this.button3.Text = "Добавить товар на склад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.storebutton_Click);
            // 
            // courierList
            // 
            this.courierList.BackColor = System.Drawing.Color.Silver;
            this.courierList.Controls.Add(this.listBox4);
            this.courierList.Controls.Add(this.listBox3);
            this.courierList.Controls.Add(this.button2);
            this.courierList.Location = new System.Drawing.Point(4, 28);
            this.courierList.Name = "courierList";
            this.courierList.Padding = new System.Windows.Forms.Padding(3);
            this.courierList.Size = new System.Drawing.Size(705, 530);
            this.courierList.TabIndex = 1;
            this.courierList.Tag = "1";
            this.courierList.Text = "Список отправки";
            // 
            // listBox4
            // 
            this.listBox4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 19;
            this.listBox4.Location = new System.Drawing.Point(12, 30);
            this.listBox4.Name = "listBox4";
            this.listBox4.ScrollAlwaysVisible = true;
            this.listBox4.Size = new System.Drawing.Size(680, 422);
            this.listBox4.TabIndex = 3;
            // 
            // listBox3
            // 
            this.listBox3.Enabled = false;
            this.listBox3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 19;
            this.listBox3.Items.AddRange(new object[] {
            "??????????????????????????????"});
            this.listBox3.Location = new System.Drawing.Point(12, 7);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(680, 23);
            this.listBox3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(285, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отправить Курьеру";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.courierbutton2_Click);
            // 
            // orderList
            // 
            this.orderList.BackColor = System.Drawing.Color.Silver;
            this.orderList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.orderList.Controls.Add(this.listBox2);
            this.orderList.Controls.Add(this.button1);
            this.orderList.Controls.Add(this.listBox1);
            this.orderList.Location = new System.Drawing.Point(4, 28);
            this.orderList.Name = "orderList";
            this.orderList.Padding = new System.Windows.Forms.Padding(3);
            this.orderList.Size = new System.Drawing.Size(705, 530);
            this.orderList.TabIndex = 0;
            this.orderList.Tag = "0";
            this.orderList.Text = "Список заказов";
            // 
            // listBox2
            // 
            this.listBox2.Enabled = false;
            this.listBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Items.AddRange(new object[] {
            "Менеджер Заказ"});
            this.listBox2.Location = new System.Drawing.Point(12, 7);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(680, 23);
            this.listBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(285, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить в список";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(12, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(680, 422);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.orderList);
            this.tabControl1.Controls.Add(this.courierList);
            this.tabControl1.Controls.Add(this.toStockList);
            this.tabControl1.Controls.Add(this.errorList);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(-5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 562);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // timerError
            // 
            this.timerError.Enabled = true;
            this.timerError.Interval = 1000;
            this.timerError.Tick += new System.EventHandler(this.timerError_Tick);
            // 
            // StoreKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StoreKeeper";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сервис Кладовщика";
            this.errorList.ResumeLayout(false);
            this.toStockList.ResumeLayout(false);
            this.courierList.ResumeLayout(false);
            this.orderList.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerOrder;
        private System.Windows.Forms.TabPage errorList;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage toStockList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage courierList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage orderList;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Timer timerError;
    }
}
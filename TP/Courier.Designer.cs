namespace TP
{
    partial class Courier
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
            this.courierList = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.deliveriList = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.courierList.SuspendLayout();
            this.deliveriList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.courierList);
            this.tabControl1.Controls.Add(this.deliveriList);
            this.tabControl1.Location = new System.Drawing.Point(-5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // courierList
            // 
            this.courierList.BackColor = System.Drawing.Color.Silver;
            this.courierList.Controls.Add(this.button1);
            this.courierList.Controls.Add(this.listBox1);
            this.courierList.Location = new System.Drawing.Point(4, 22);
            this.courierList.Name = "courierList";
            this.courierList.Padding = new System.Windows.Forms.Padding(3);
            this.courierList.Size = new System.Drawing.Size(705, 536);
            this.courierList.TabIndex = 0;
            this.courierList.Text = "Список заказов";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить в Доставки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addToDeliverbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(680, 446);
            this.listBox1.TabIndex = 0;
            // 
            // deliveriList
            // 
            this.deliveriList.BackColor = System.Drawing.Color.Silver;
            this.deliveriList.Controls.Add(this.button3);
            this.deliveriList.Controls.Add(this.button2);
            this.deliveriList.Controls.Add(this.listBox2);
            this.deliveriList.Location = new System.Drawing.Point(4, 22);
            this.deliveriList.Name = "deliveriList";
            this.deliveriList.Padding = new System.Windows.Forms.Padding(3);
            this.deliveriList.Size = new System.Drawing.Size(705, 536);
            this.deliveriList.TabIndex = 1;
            this.deliveriList.Text = "Список доставок";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(430, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Отмена заказа";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Доставлено";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.confirmbutton_Click);
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
            // Courier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Courier";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courier Service";
            this.tabControl1.ResumeLayout(false);
            this.courierList.ResumeLayout(false);
            this.deliveriList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage courierList;
        private System.Windows.Forms.TabPage deliveriList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button3;
    }
}
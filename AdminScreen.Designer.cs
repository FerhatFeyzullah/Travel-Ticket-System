namespace Travel_Ticket_System
{
    partial class AdminScreen
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.adminGirisPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adminScreenPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.firmalarList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.adminGirisPanel.SuspendLayout();
            this.adminScreenPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 40);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 101);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 40);
            this.textBox2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(62, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // adminGirisPanel
            // 
            this.adminGirisPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.adminGirisPanel.Controls.Add(this.label1);
            this.adminGirisPanel.Controls.Add(this.checkBox1);
            this.adminGirisPanel.Controls.Add(this.textBox2);
            this.adminGirisPanel.Controls.Add(this.button1);
            this.adminGirisPanel.Controls.Add(this.textBox1);
            this.adminGirisPanel.Location = new System.Drawing.Point(285, 92);
            this.adminGirisPanel.Name = "adminGirisPanel";
            this.adminGirisPanel.Size = new System.Drawing.Size(200, 250);
            this.adminGirisPanel.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(55, 154);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin Girişi";
            // 
            // adminScreenPanel
            // 
            this.adminScreenPanel.Controls.Add(this.panel1);
            this.adminScreenPanel.Controls.Add(this.label3);
            this.adminScreenPanel.Controls.Add(this.firmalarList);
            this.adminScreenPanel.Location = new System.Drawing.Point(0, 4);
            this.adminScreenPanel.Name = "adminScreenPanel";
            this.adminScreenPanel.Size = new System.Drawing.Size(763, 415);
            this.adminScreenPanel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(104, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Firmalar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firmalarList
            // 
            this.firmalarList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.firmalarList.FormattingEnabled = true;
            this.firmalarList.Location = new System.Drawing.Point(76, 115);
            this.firmalarList.Name = "firmalarList";
            this.firmalarList.Size = new System.Drawing.Size(139, 21);
            this.firmalarList.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Location = new System.Drawing.Point(346, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 229);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(38, 81);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 30);
            this.textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(202, 81);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 30);
            this.textBox4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(79, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firma Ekleme - Çıkarma";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(49, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "EKLE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(214, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "ÇIKART";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(754, 431);
            this.Controls.Add(this.adminScreenPanel);
            this.Controls.Add(this.adminGirisPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " AdminScreen";
            this.adminGirisPanel.ResumeLayout(false);
            this.adminGirisPanel.PerformLayout();
            this.adminScreenPanel.ResumeLayout(false);
            this.adminScreenPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel adminGirisPanel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel adminScreenPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox firmalarList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}
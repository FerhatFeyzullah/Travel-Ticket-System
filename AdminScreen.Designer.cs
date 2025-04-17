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
            this.kullaniciAdiText = new System.Windows.Forms.TextBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.adminGirisYapButton = new System.Windows.Forms.Button();
            this.adminGirisPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminSifreyiGosterCBox = new System.Windows.Forms.CheckBox();
            this.adminScreenPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firmaCikartButon = new System.Windows.Forms.Button();
            this.firmaEkleButon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.firmaCikartText = new System.Windows.Forms.TextBox();
            this.firmaEkleText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firmalarList = new System.Windows.Forms.ComboBox();
            this.cmbFirmaTipiList = new System.Windows.Forms.ComboBox();
            this.adminGirisPanel.SuspendLayout();
            this.adminScreenPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullaniciAdiText
            // 
            this.kullaniciAdiText.Location = new System.Drawing.Point(34, 72);
            this.kullaniciAdiText.Name = "kullaniciAdiText";
            this.kullaniciAdiText.Size = new System.Drawing.Size(130, 20);
            this.kullaniciAdiText.TabIndex = 0;
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(34, 130);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(130, 20);
            this.sifreText.TabIndex = 0;
            // 
            // adminGirisYapButton
            // 
            this.adminGirisYapButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminGirisYapButton.Location = new System.Drawing.Point(61, 195);
            this.adminGirisYapButton.Name = "adminGirisYapButton";
            this.adminGirisYapButton.Size = new System.Drawing.Size(75, 35);
            this.adminGirisYapButton.TabIndex = 1;
            this.adminGirisYapButton.Text = "Giriş Yap";
            this.adminGirisYapButton.UseVisualStyleBackColor = true;
            this.adminGirisYapButton.Click += new System.EventHandler(this.adminGirisYapButton_Click);
            // 
            // adminGirisPanel
            // 
            this.adminGirisPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.adminGirisPanel.Controls.Add(this.label5);
            this.adminGirisPanel.Controls.Add(this.label4);
            this.adminGirisPanel.Controls.Add(this.label1);
            this.adminGirisPanel.Controls.Add(this.adminSifreyiGosterCBox);
            this.adminGirisPanel.Controls.Add(this.sifreText);
            this.adminGirisPanel.Controls.Add(this.adminGirisYapButton);
            this.adminGirisPanel.Controls.Add(this.kullaniciAdiText);
            this.adminGirisPanel.Location = new System.Drawing.Point(285, 92);
            this.adminGirisPanel.Name = "adminGirisPanel";
            this.adminGirisPanel.Size = new System.Drawing.Size(200, 250);
            this.adminGirisPanel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(34, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(34, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şifre:";
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
            // adminSifreyiGosterCBox
            // 
            this.adminSifreyiGosterCBox.AutoSize = true;
            this.adminSifreyiGosterCBox.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminSifreyiGosterCBox.Location = new System.Drawing.Point(54, 169);
            this.adminSifreyiGosterCBox.Name = "adminSifreyiGosterCBox";
            this.adminSifreyiGosterCBox.Size = new System.Drawing.Size(89, 20);
            this.adminSifreyiGosterCBox.TabIndex = 2;
            this.adminSifreyiGosterCBox.Text = "Şifreyi Göster";
            this.adminSifreyiGosterCBox.UseVisualStyleBackColor = true;
            this.adminSifreyiGosterCBox.CheckedChanged += new System.EventHandler(this.adminSifreyiGosterCBox_CheckedChanged);
            // 
            // adminScreenPanel
            // 
            this.adminScreenPanel.Controls.Add(this.panel1);
            this.adminScreenPanel.Controls.Add(this.label3);
            this.adminScreenPanel.Controls.Add(this.firmalarList);
            this.adminScreenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.adminScreenPanel.Name = "adminScreenPanel";
            this.adminScreenPanel.Size = new System.Drawing.Size(754, 431);
            this.adminScreenPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.cmbFirmaTipiList);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.firmaCikartButon);
            this.panel1.Controls.Add(this.firmaEkleButon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.firmaCikartText);
            this.panel1.Controls.Add(this.firmaEkleText);
            this.panel1.Location = new System.Drawing.Point(346, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 229);
            this.panel1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Firma Tipi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Firma İsmi:";
            // 
            // firmaCikartButon
            // 
            this.firmaCikartButon.BackColor = System.Drawing.SystemColors.Control;
            this.firmaCikartButon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmaCikartButon.Location = new System.Drawing.Point(214, 132);
            this.firmaCikartButon.Name = "firmaCikartButon";
            this.firmaCikartButon.Size = new System.Drawing.Size(75, 23);
            this.firmaCikartButon.TabIndex = 2;
            this.firmaCikartButon.Text = "ÇIKART";
            this.firmaCikartButon.UseVisualStyleBackColor = false;
            // 
            // firmaEkleButon
            // 
            this.firmaEkleButon.BackColor = System.Drawing.SystemColors.Control;
            this.firmaEkleButon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmaEkleButon.Location = new System.Drawing.Point(46, 174);
            this.firmaEkleButon.Name = "firmaEkleButon";
            this.firmaEkleButon.Size = new System.Drawing.Size(75, 23);
            this.firmaEkleButon.TabIndex = 2;
            this.firmaEkleButon.Text = "EKLE";
            this.firmaEkleButon.UseVisualStyleBackColor = false;
            this.firmaEkleButon.Click += new System.EventHandler(this.firmaEkleButon_Click);
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
            // firmaCikartText
            // 
            this.firmaCikartText.Location = new System.Drawing.Point(202, 81);
            this.firmaCikartText.Multiline = true;
            this.firmaCikartText.Name = "firmaCikartText";
            this.firmaCikartText.Size = new System.Drawing.Size(100, 30);
            this.firmaCikartText.TabIndex = 0;
            // 
            // firmaEkleText
            // 
            this.firmaEkleText.Location = new System.Drawing.Point(36, 70);
            this.firmaEkleText.Multiline = true;
            this.firmaEkleText.Name = "firmaEkleText";
            this.firmaEkleText.Size = new System.Drawing.Size(100, 30);
            this.firmaEkleText.TabIndex = 0;
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
            this.firmalarList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firmalarList.FormattingEnabled = true;
            this.firmalarList.Location = new System.Drawing.Point(76, 115);
            this.firmalarList.Name = "firmalarList";
            this.firmalarList.Size = new System.Drawing.Size(139, 21);
            this.firmalarList.TabIndex = 7;
            // 
            // cmbFirmaTipiList
            // 
            this.cmbFirmaTipiList.FormattingEnabled = true;
            this.cmbFirmaTipiList.Items.AddRange(new object[] {
            "Otobüs",
            "Uçak",
            "Tren"});
            this.cmbFirmaTipiList.Location = new System.Drawing.Point(36, 134);
            this.cmbFirmaTipiList.Name = "cmbFirmaTipiList";
            this.cmbFirmaTipiList.Size = new System.Drawing.Size(100, 21);
            this.cmbFirmaTipiList.TabIndex = 5;
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
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.adminGirisPanel.ResumeLayout(false);
            this.adminGirisPanel.PerformLayout();
            this.adminScreenPanel.ResumeLayout(false);
            this.adminScreenPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox kullaniciAdiText;
        private System.Windows.Forms.Button adminGirisYapButton;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Panel adminGirisPanel;
        private System.Windows.Forms.CheckBox adminSifreyiGosterCBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel adminScreenPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox firmalarList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox firmaCikartText;
        private System.Windows.Forms.TextBox firmaEkleText;
        private System.Windows.Forms.Button firmaCikartButon;
        private System.Windows.Forms.Button firmaEkleButon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFirmaTipiList;
    }
}
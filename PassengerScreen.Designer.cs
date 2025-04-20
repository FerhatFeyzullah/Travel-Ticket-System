namespace Travel_Ticket_System
{
    partial class PassengerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengerScreen));
            this.biletAramaPanel = new System.Windows.Forms.Panel();
            this.seferGosterPanel = new System.Windows.Forms.Panel();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.dtpSeferTarihi = new System.Windows.Forms.DateTimePicker();
            this.Tren = new System.Windows.Forms.Button();
            this.Ucak = new System.Windows.Forms.Button();
            this.Otobus = new System.Windows.Forms.Button();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.filtreleButton = new System.Windows.Forms.Button();
            this.seferGosterPanelAna = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.biletAramaPanel.SuspendLayout();
            this.seferGosterPanelAna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // biletAramaPanel
            // 
            this.biletAramaPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.biletAramaPanel.Controls.Add(this.seferGosterPanelAna);
            this.biletAramaPanel.Controls.Add(this.pictureBox4);
            this.biletAramaPanel.Controls.Add(this.pictureBox3);
            this.biletAramaPanel.Controls.Add(this.pictureBox2);
            this.biletAramaPanel.Controls.Add(this.pictureBox1);
            this.biletAramaPanel.Controls.Add(this.cmbNereye);
            this.biletAramaPanel.Controls.Add(this.cmbNereden);
            this.biletAramaPanel.Controls.Add(this.dtpSeferTarihi);
            this.biletAramaPanel.Controls.Add(this.Tren);
            this.biletAramaPanel.Controls.Add(this.Ucak);
            this.biletAramaPanel.Controls.Add(this.Otobus);
            this.biletAramaPanel.Controls.Add(this.label4);
            this.biletAramaPanel.Controls.Add(this.label5);
            this.biletAramaPanel.Controls.Add(this.label6);
            this.biletAramaPanel.Controls.Add(this.filtreleButton);
            this.biletAramaPanel.Controls.Add(this.richTextBox7);
            this.biletAramaPanel.Controls.Add(this.richTextBox8);
            this.biletAramaPanel.Controls.Add(this.richTextBox5);
            this.biletAramaPanel.Controls.Add(this.richTextBox6);
            this.biletAramaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.biletAramaPanel.Location = new System.Drawing.Point(0, 0);
            this.biletAramaPanel.Name = "biletAramaPanel";
            this.biletAramaPanel.Size = new System.Drawing.Size(754, 489);
            this.biletAramaPanel.TabIndex = 1;
            // 
            // seferGosterPanel
            // 
            this.seferGosterPanel.AutoScroll = true;
            this.seferGosterPanel.Location = new System.Drawing.Point(0, 32);
            this.seferGosterPanel.Name = "seferGosterPanel";
            this.seferGosterPanel.Size = new System.Drawing.Size(754, 376);
            this.seferGosterPanel.TabIndex = 2;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(3, 3);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(54, 23);
            this.btnGeriDon.TabIndex = 0;
            this.btnGeriDon.Text = "< Geri";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // cmbNereye
            // 
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Items.AddRange(new object[] {
            "Sakarya",
            "Kocaeli",
            "Ankara",
            "Istanbul",
            "Trabzon"});
            this.cmbNereye.Location = new System.Drawing.Point(225, 119);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(106, 21);
            this.cmbNereye.TabIndex = 15;
            // 
            // cmbNereden
            // 
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Items.AddRange(new object[] {
            "Sakarya",
            "Kocaeli",
            "Ankara",
            "Istanbul",
            "Trabzon"});
            this.cmbNereden.Location = new System.Drawing.Point(84, 119);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(106, 21);
            this.cmbNereden.TabIndex = 14;
            // 
            // dtpSeferTarihi
            // 
            this.dtpSeferTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSeferTarihi.Location = new System.Drawing.Point(369, 116);
            this.dtpSeferTarihi.Name = "dtpSeferTarihi";
            this.dtpSeferTarihi.Size = new System.Drawing.Size(104, 20);
            this.dtpSeferTarihi.TabIndex = 12;
            // 
            // Tren
            // 
            this.Tren.Location = new System.Drawing.Point(369, 20);
            this.Tren.Name = "Tren";
            this.Tren.Size = new System.Drawing.Size(87, 40);
            this.Tren.TabIndex = 9;
            this.Tren.Text = "Tren";
            this.Tren.UseVisualStyleBackColor = true;
            this.Tren.Click += new System.EventHandler(this.Tren_Click);
            // 
            // Ucak
            // 
            this.Ucak.Location = new System.Drawing.Point(225, 20);
            this.Ucak.Name = "Ucak";
            this.Ucak.Size = new System.Drawing.Size(87, 40);
            this.Ucak.TabIndex = 9;
            this.Ucak.Text = "Uçak";
            this.Ucak.UseVisualStyleBackColor = true;
            this.Ucak.Click += new System.EventHandler(this.Ucak_Click);
            // 
            // Otobus
            // 
            this.Otobus.Location = new System.Drawing.Point(84, 20);
            this.Otobus.Name = "Otobus";
            this.Otobus.Size = new System.Drawing.Size(87, 40);
            this.Otobus.TabIndex = 9;
            this.Otobus.Text = "Otobüs";
            this.Otobus.UseVisualStyleBackColor = true;
            this.Otobus.Click += new System.EventHandler(this.Otobus_Click);
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.Gainsboro;
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox5.Location = new System.Drawing.Point(12, 233);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(134, 245);
            this.richTextBox5.TabIndex = 8;
            this.richTextBox5.Text = resources.GetString("richTextBox5.Text");
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.Color.Gainsboro;
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox6.Location = new System.Drawing.Point(610, 233);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(134, 245);
            this.richTextBox6.TabIndex = 8;
            this.richTextBox6.Text = resources.GetString("richTextBox6.Text");
            // 
            // richTextBox7
            // 
            this.richTextBox7.BackColor = System.Drawing.Color.Gainsboro;
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox7.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox7.Location = new System.Drawing.Point(412, 233);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(134, 245);
            this.richTextBox7.TabIndex = 8;
            this.richTextBox7.Text = "\n\n\n\n\nBütçe Dostu\n\nHuhubilet size tüm firmaların otobüs biletlerini sorgulama ve k" +
    "arşılaştırma imkanı sunar. Bu sayede bütçenize uygun otobüs biletini rahatlıkla " +
    "bulabilir ve satın alabilirsiniz.";
            // 
            // richTextBox8
            // 
            this.richTextBox8.BackColor = System.Drawing.Color.Gainsboro;
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox8.Location = new System.Drawing.Point(206, 233);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(134, 245);
            this.richTextBox8.TabIndex = 8;
            this.richTextBox8.Text = "\n\n\n\n\nGüvenli Ödeme\n\nTüm otobüs bilet alım işlemlerinizi ister evinizden, ister of" +
    "isinizden ya da dilerseniz cep telefonunuzdan kolay, hızlı ve güvenilir bir şeki" +
    "lde gerçekleştirebilirsiniz.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(366, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gidiş Tarihi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(222, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nereye";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(81, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nereden";
            // 
            // filtreleButton
            // 
            this.filtreleButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filtreleButton.Location = new System.Drawing.Point(563, 106);
            this.filtreleButton.Name = "filtreleButton";
            this.filtreleButton.Size = new System.Drawing.Size(107, 30);
            this.filtreleButton.TabIndex = 2;
            this.filtreleButton.Text = "Sefer Ara";
            this.filtreleButton.UseVisualStyleBackColor = true;
            this.filtreleButton.Click += new System.EventHandler(this.filtreleButton_Click_1);
            // 
            // seferGosterPanelAna
            // 
            this.seferGosterPanelAna.Controls.Add(this.btnGeriDon);
            this.seferGosterPanelAna.Controls.Add(this.seferGosterPanel);
            this.seferGosterPanelAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seferGosterPanelAna.Location = new System.Drawing.Point(0, 0);
            this.seferGosterPanelAna.Name = "seferGosterPanelAna";
            this.seferGosterPanelAna.Size = new System.Drawing.Size(754, 489);
            this.seferGosterPanelAna.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(206, 233);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(412, 233);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(610, 233);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // PassengerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 489);
            this.Controls.Add(this.biletAramaPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassengerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassengerScreen";
            this.Load += new System.EventHandler(this.PassengerScreen_Load);
            this.biletAramaPanel.ResumeLayout(false);
            this.biletAramaPanel.PerformLayout();
            this.seferGosterPanelAna.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel biletAramaPanel;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button filtreleButton;
        private System.Windows.Forms.Button Tren;
        private System.Windows.Forms.Button Ucak;
        private System.Windows.Forms.Button Otobus;
        private System.Windows.Forms.DateTimePicker dtpSeferTarihi;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.ComboBox cmbNereden;
        private System.Windows.Forms.Panel seferGosterPanel;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Panel seferGosterPanelAna;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
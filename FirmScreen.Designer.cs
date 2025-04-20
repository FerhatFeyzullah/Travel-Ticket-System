namespace Travel_Ticket_System
{
    partial class FirmScreen
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
            this.firmGirisPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firmSifreyiGosterCBox = new System.Windows.Forms.CheckBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.firmGirisYapButton = new System.Windows.Forms.Button();
            this.kullaniciAdiText = new System.Windows.Forms.TextBox();
            this.panelFirmScreen = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbMevcutAraclarCikarList = new System.Windows.Forms.ComboBox();
            this.cmbAracTipiEkle = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMevcutAraclarList = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.aracCikarButton = new System.Windows.Forms.Button();
            this.aracEkleButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.gelenPlakaEkleme = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMevcutSeferlerdenCikar = new System.Windows.Forms.ComboBox();
            this.seferTarihEkle = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMevcutSeferList = new System.Windows.Forms.ComboBox();
            this.cmbAracTipiSeferEkle = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.neredenEkle = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.seferCikartButon = new System.Windows.Forms.Button();
            this.seferEkleButon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.seferNereyeEkle = new System.Windows.Forms.TextBox();
            this.seferNeredenEkle = new System.Windows.Forms.TextBox();
            this.firmNameText = new System.Windows.Forms.Label();
            this.firmGirisPanel.SuspendLayout();
            this.panelFirmScreen.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firmGirisPanel
            // 
            this.firmGirisPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.firmGirisPanel.Controls.Add(this.label5);
            this.firmGirisPanel.Controls.Add(this.label4);
            this.firmGirisPanel.Controls.Add(this.label1);
            this.firmGirisPanel.Controls.Add(this.firmSifreyiGosterCBox);
            this.firmGirisPanel.Controls.Add(this.sifreText);
            this.firmGirisPanel.Controls.Add(this.firmGirisYapButton);
            this.firmGirisPanel.Controls.Add(this.kullaniciAdiText);
            this.firmGirisPanel.Location = new System.Drawing.Point(382, 92);
            this.firmGirisPanel.Name = "firmGirisPanel";
            this.firmGirisPanel.Size = new System.Drawing.Size(200, 250);
            this.firmGirisPanel.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Firma Girişi";
            // 
            // firmSifreyiGosterCBox
            // 
            this.firmSifreyiGosterCBox.AutoSize = true;
            this.firmSifreyiGosterCBox.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmSifreyiGosterCBox.Location = new System.Drawing.Point(54, 169);
            this.firmSifreyiGosterCBox.Name = "firmSifreyiGosterCBox";
            this.firmSifreyiGosterCBox.Size = new System.Drawing.Size(89, 20);
            this.firmSifreyiGosterCBox.TabIndex = 2;
            this.firmSifreyiGosterCBox.Text = "Şifreyi Göster";
            this.firmSifreyiGosterCBox.UseVisualStyleBackColor = true;
            this.firmSifreyiGosterCBox.CheckedChanged += new System.EventHandler(this.firmSifreyiGosterCBox_CheckedChanged);
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(34, 130);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(130, 20);
            this.sifreText.TabIndex = 0;
            // 
            // firmGirisYapButton
            // 
            this.firmGirisYapButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmGirisYapButton.Location = new System.Drawing.Point(61, 195);
            this.firmGirisYapButton.Name = "firmGirisYapButton";
            this.firmGirisYapButton.Size = new System.Drawing.Size(75, 35);
            this.firmGirisYapButton.TabIndex = 1;
            this.firmGirisYapButton.Text = "Giriş Yap";
            this.firmGirisYapButton.UseVisualStyleBackColor = true;
            this.firmGirisYapButton.Click += new System.EventHandler(this.firmGirisYapButton_Click);
            // 
            // kullaniciAdiText
            // 
            this.kullaniciAdiText.Location = new System.Drawing.Point(34, 72);
            this.kullaniciAdiText.Name = "kullaniciAdiText";
            this.kullaniciAdiText.Size = new System.Drawing.Size(130, 20);
            this.kullaniciAdiText.TabIndex = 0;
            // 
            // panelFirmScreen
            // 
            this.panelFirmScreen.BackColor = System.Drawing.Color.Gainsboro;
            this.panelFirmScreen.Controls.Add(this.panel2);
            this.panelFirmScreen.Controls.Add(this.panel1);
            this.panelFirmScreen.Controls.Add(this.firmNameText);
            this.panelFirmScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFirmScreen.Location = new System.Drawing.Point(0, 0);
            this.panelFirmScreen.Name = "panelFirmScreen";
            this.panelFirmScreen.Size = new System.Drawing.Size(948, 457);
            this.panelFirmScreen.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.cmbMevcutAraclarCikarList);
            this.panel2.Controls.Add(this.cmbAracTipiEkle);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbMevcutAraclarList);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.aracCikarButton);
            this.panel2.Controls.Add(this.aracEkleButton);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.gelenPlakaEkleme);
            this.panel2.Location = new System.Drawing.Point(12, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 397);
            this.panel2.TabIndex = 11;
            // 
            // cmbMevcutAraclarCikarList
            // 
            this.cmbMevcutAraclarCikarList.FormattingEnabled = true;
            this.cmbMevcutAraclarCikarList.Location = new System.Drawing.Point(37, 225);
            this.cmbMevcutAraclarCikarList.Name = "cmbMevcutAraclarCikarList";
            this.cmbMevcutAraclarCikarList.Size = new System.Drawing.Size(104, 21);
            this.cmbMevcutAraclarCikarList.TabIndex = 8;
            // 
            // cmbAracTipiEkle
            // 
            this.cmbAracTipiEkle.FormattingEnabled = true;
            this.cmbAracTipiEkle.Items.AddRange(new object[] {
            "Otobüs",
            "Uçak",
            "Tren"});
            this.cmbAracTipiEkle.Location = new System.Drawing.Point(37, 113);
            this.cmbAracTipiEkle.Name = "cmbAracTipiEkle";
            this.cmbAracTipiEkle.Size = new System.Drawing.Size(100, 21);
            this.cmbAracTipiEkle.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Araç Tipi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mevcut Araçlar";
            // 
            // cmbMevcutAraclarList
            // 
            this.cmbMevcutAraclarList.FormattingEnabled = true;
            this.cmbMevcutAraclarList.Location = new System.Drawing.Point(201, 50);
            this.cmbMevcutAraclarList.Name = "cmbMevcutAraclarList";
            this.cmbMevcutAraclarList.Size = new System.Drawing.Size(121, 21);
            this.cmbMevcutAraclarList.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Çıkarılacak Araç:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Araç Plakası:";
            // 
            // aracCikarButton
            // 
            this.aracCikarButton.BackColor = System.Drawing.SystemColors.Control;
            this.aracCikarButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracCikarButton.Location = new System.Drawing.Point(49, 268);
            this.aracCikarButton.Name = "aracCikarButton";
            this.aracCikarButton.Size = new System.Drawing.Size(75, 23);
            this.aracCikarButton.TabIndex = 2;
            this.aracCikarButton.Text = "ÇIKART";
            this.aracCikarButton.UseVisualStyleBackColor = false;
            this.aracCikarButton.Click += new System.EventHandler(this.aracCikarButton_Click);
            // 
            // aracEkleButton
            // 
            this.aracEkleButton.BackColor = System.Drawing.SystemColors.Control;
            this.aracEkleButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracEkleButton.Location = new System.Drawing.Point(48, 157);
            this.aracEkleButton.Name = "aracEkleButton";
            this.aracEkleButton.Size = new System.Drawing.Size(75, 23);
            this.aracEkleButton.TabIndex = 2;
            this.aracEkleButton.Text = "EKLE";
            this.aracEkleButton.UseVisualStyleBackColor = false;
            this.aracEkleButton.Click += new System.EventHandler(this.aracEkleButton_Click);
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(343, 19);
            this.label13.TabIndex = 1;
            this.label13.Text = "Araç Ekleme - Çıkarma";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gelenPlakaEkleme
            // 
            this.gelenPlakaEkleme.Location = new System.Drawing.Point(37, 51);
            this.gelenPlakaEkleme.Multiline = true;
            this.gelenPlakaEkleme.Name = "gelenPlakaEkleme";
            this.gelenPlakaEkleme.Size = new System.Drawing.Size(100, 30);
            this.gelenPlakaEkleme.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.cmbMevcutSeferlerdenCikar);
            this.panel1.Controls.Add(this.seferTarihEkle);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbMevcutSeferList);
            this.panel1.Controls.Add(this.cmbAracTipiSeferEkle);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.neredenEkle);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.seferCikartButon);
            this.panel1.Controls.Add(this.seferEkleButon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.seferNereyeEkle);
            this.panel1.Controls.Add(this.seferNeredenEkle);
            this.panel1.Location = new System.Drawing.Point(371, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 397);
            this.panel1.TabIndex = 10;
            // 
            // cmbMevcutSeferlerdenCikar
            // 
            this.cmbMevcutSeferlerdenCikar.FormattingEnabled = true;
            this.cmbMevcutSeferlerdenCikar.Location = new System.Drawing.Point(24, 159);
            this.cmbMevcutSeferlerdenCikar.Name = "cmbMevcutSeferlerdenCikar";
            this.cmbMevcutSeferlerdenCikar.Size = new System.Drawing.Size(301, 21);
            this.cmbMevcutSeferlerdenCikar.TabIndex = 9;
            // 
            // seferTarihEkle
            // 
            this.seferTarihEkle.CustomFormat = "\"dd.MM.yyyy HH:mm\"";
            this.seferTarihEkle.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.seferTarihEkle.Location = new System.Drawing.Point(410, 51);
            this.seferTarihEkle.Name = "seferTarihEkle";
            this.seferTarihEkle.ShowUpDown = true;
            this.seferTarihEkle.Size = new System.Drawing.Size(122, 20);
            this.seferTarihEkle.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mevcut Seferler:";
            // 
            // cmbMevcutSeferList
            // 
            this.cmbMevcutSeferList.FormattingEnabled = true;
            this.cmbMevcutSeferList.Location = new System.Drawing.Point(24, 271);
            this.cmbMevcutSeferList.Name = "cmbMevcutSeferList";
            this.cmbMevcutSeferList.Size = new System.Drawing.Size(301, 21);
            this.cmbMevcutSeferList.TabIndex = 6;
            // 
            // cmbAracTipiSeferEkle
            // 
            this.cmbAracTipiSeferEkle.FormattingEnabled = true;
            this.cmbAracTipiSeferEkle.Location = new System.Drawing.Point(290, 51);
            this.cmbAracTipiSeferEkle.Name = "cmbAracTipiSeferEkle";
            this.cmbAracTipiSeferEkle.Size = new System.Drawing.Size(100, 21);
            this.cmbAracTipiSeferEkle.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(407, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Tarih:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hangi Araç:";
            // 
            // neredenEkle
            // 
            this.neredenEkle.AutoSize = true;
            this.neredenEkle.Location = new System.Drawing.Point(21, 143);
            this.neredenEkle.Name = "neredenEkle";
            this.neredenEkle.Size = new System.Drawing.Size(87, 13);
            this.neredenEkle.TabIndex = 3;
            this.neredenEkle.Text = "Çıkarılacak Sefer";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(164, 35);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Nereye:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nereden:";
            // 
            // seferCikartButon
            // 
            this.seferCikartButon.BackColor = System.Drawing.SystemColors.Control;
            this.seferCikartButon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seferCikartButon.Location = new System.Drawing.Point(366, 159);
            this.seferCikartButon.Name = "seferCikartButon";
            this.seferCikartButon.Size = new System.Drawing.Size(75, 23);
            this.seferCikartButon.TabIndex = 2;
            this.seferCikartButon.Text = "ÇIKART";
            this.seferCikartButon.UseVisualStyleBackColor = false;
            this.seferCikartButon.Click += new System.EventHandler(this.seferCikartButon_Click);
            // 
            // seferEkleButon
            // 
            this.seferEkleButon.BackColor = System.Drawing.SystemColors.Control;
            this.seferEkleButon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seferEkleButon.Location = new System.Drawing.Point(24, 98);
            this.seferEkleButon.Name = "seferEkleButon";
            this.seferEkleButon.Size = new System.Drawing.Size(75, 23);
            this.seferEkleButon.TabIndex = 2;
            this.seferEkleButon.Text = "EKLE";
            this.seferEkleButon.UseVisualStyleBackColor = false;
            this.seferEkleButon.Click += new System.EventHandler(this.seferEkleButon_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(563, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sefer Ekleme - Çıkarma";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // seferNereyeEkle
            // 
            this.seferNereyeEkle.Location = new System.Drawing.Point(167, 51);
            this.seferNereyeEkle.Multiline = true;
            this.seferNereyeEkle.Name = "seferNereyeEkle";
            this.seferNereyeEkle.Size = new System.Drawing.Size(100, 30);
            this.seferNereyeEkle.TabIndex = 0;
            // 
            // seferNeredenEkle
            // 
            this.seferNeredenEkle.Location = new System.Drawing.Point(24, 51);
            this.seferNeredenEkle.Multiline = true;
            this.seferNeredenEkle.Name = "seferNeredenEkle";
            this.seferNeredenEkle.Size = new System.Drawing.Size(100, 30);
            this.seferNeredenEkle.TabIndex = 0;
            // 
            // firmNameText
            // 
            this.firmNameText.Dock = System.Windows.Forms.DockStyle.Top;
            this.firmNameText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmNameText.Location = new System.Drawing.Point(0, 0);
            this.firmNameText.Name = "firmNameText";
            this.firmNameText.Size = new System.Drawing.Size(948, 44);
            this.firmNameText.TabIndex = 0;
            this.firmNameText.Text = "huhu";
            this.firmNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirmScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 457);
            this.Controls.Add(this.panelFirmScreen);
            this.Controls.Add(this.firmGirisPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirmScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirmScreen";
            this.Load += new System.EventHandler(this.FirmScreen_Load);
            this.firmGirisPanel.ResumeLayout(false);
            this.firmGirisPanel.PerformLayout();
            this.panelFirmScreen.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel firmGirisPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox firmSifreyiGosterCBox;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Button firmGirisYapButton;
        private System.Windows.Forms.TextBox kullaniciAdiText;
        private System.Windows.Forms.Panel panelFirmScreen;
        private System.Windows.Forms.Label firmNameText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button aracCikarButton;
        private System.Windows.Forms.Button aracEkleButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox gelenPlakaEkleme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbAracTipiSeferEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button seferCikartButon;
        private System.Windows.Forms.Button seferEkleButon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox seferNeredenEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMevcutAraclarList;
        private System.Windows.Forms.ComboBox cmbAracTipiEkle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox seferNereyeEkle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label neredenEkle;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMevcutSeferList;
        private System.Windows.Forms.DateTimePicker seferTarihEkle;
        private System.Windows.Forms.ComboBox cmbMevcutSeferlerdenCikar;
        private System.Windows.Forms.ComboBox cmbMevcutAraclarCikarList;
    }
}
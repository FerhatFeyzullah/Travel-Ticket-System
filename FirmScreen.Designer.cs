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
            this.firmGirisPanel.SuspendLayout();
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
            this.firmGirisPanel.Location = new System.Drawing.Point(285, 92);
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
            this.panelFirmScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFirmScreen.Location = new System.Drawing.Point(0, 0);
            this.panelFirmScreen.Name = "panelFirmScreen";
            this.panelFirmScreen.Size = new System.Drawing.Size(754, 431);
            this.panelFirmScreen.TabIndex = 4;
            // 
            // FirmScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 431);
            this.Controls.Add(this.firmGirisPanel);
            this.Controls.Add(this.panelFirmScreen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirmScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirmScreen";
            this.Load += new System.EventHandler(this.FirmScreen_Load);
            this.firmGirisPanel.ResumeLayout(false);
            this.firmGirisPanel.PerformLayout();
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
    }
}
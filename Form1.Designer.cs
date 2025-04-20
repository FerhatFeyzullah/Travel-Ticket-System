namespace Travel_Ticket_System
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonYolcu = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonFirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(754, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\nSeyahat Bilet Sistemine Hoş Geldiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonYolcu
            // 
            this.buttonYolcu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYolcu.Location = new System.Drawing.Point(282, 143);
            this.buttonYolcu.Name = "buttonYolcu";
            this.buttonYolcu.Size = new System.Drawing.Size(166, 46);
            this.buttonYolcu.TabIndex = 1;
            this.buttonYolcu.Text = "Yolcu Girişi";
            this.buttonYolcu.UseVisualStyleBackColor = true;
            this.buttonYolcu.Click += new System.EventHandler(this.buttonYolcu_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdmin.Location = new System.Drawing.Point(282, 226);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(166, 46);
            this.buttonAdmin.TabIndex = 1;
            this.buttonAdmin.Text = "Admin Girişi";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonFirma
            // 
            this.buttonFirma.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonFirma.Location = new System.Drawing.Point(282, 308);
            this.buttonFirma.Name = "buttonFirma";
            this.buttonFirma.Size = new System.Drawing.Size(166, 46);
            this.buttonFirma.TabIndex = 1;
            this.buttonFirma.Text = "Firma Girişi";
            this.buttonFirma.UseVisualStyleBackColor = true;
            this.buttonFirma.Click += new System.EventHandler(this.buttonFirma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(754, 431);
            this.Controls.Add(this.buttonFirma);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonYolcu);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonYolcu;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonFirma;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_Ticket_System.Class;
using static Travel_Ticket_System.Class.LoginManager;

namespace Travel_Ticket_System
{
    public partial class FirmScreen : Form
    {
        public FirmScreen()
        {
            InitializeComponent();
        }
        

        private void FirmScreen_Load(object sender, EventArgs e)
        {
            firmGirisPanel.Visible = false;
            panelFirmScreen.Visible = true;
            sifreText.UseSystemPasswordChar = true;
        }

        private void firmGirisYapButton_Click(object sender, EventArgs e)
        {

            bool durum = false;
            for (int i = 0; i < Buisness.Firmalar.Count; i++)
            {
                if (Buisness.Firmalar[i].GirisYap(kullaniciAdiText.Text, sifreText.Text))
                {
                    panelFirmScreen.Visible = true;
                    firmGirisPanel.Visible = false;
                    durum = true;
                    break;

                }
                
            }
            if (!durum)
            {
                MessageBox.Show("Hatalı firma girişi!");
                kullaniciAdiText.Text = "";
                sifreText.Text = "";
            }
            



        }

        private void firmSifreyiGosterCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (firmSifreyiGosterCBox.Checked)
            {
                sifreText.UseSystemPasswordChar = false;
            }
            else
            {
                sifreText.UseSystemPasswordChar = true;
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_Ticket_System.Class;

namespace Travel_Ticket_System
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        Login admin = new LoginManager.Admin("admin", "12345");
        Business business = new Business();




        private void AdminScreen_Load(object sender, EventArgs e)
        {
            adminScreenPanel.Visible = false;
            adminGirisPanel.Visible = true;
            sifreText.UseSystemPasswordChar = true;
            GuncelleComboBox();
            

        }

        private void adminGirisYapButton_Click(object sender, EventArgs e)
        {
            if (admin.GirisYap(kullaniciAdiText.Text, sifreText.Text))
            {
                adminScreenPanel.Visible = true;
                adminGirisPanel.Visible = false;

            }
            else
            {
                MessageBox.Show("Hatalı admin girişi!");
                kullaniciAdiText.Text = "";
                sifreText.Text = "";
            }


        }

        private void adminSifreyiGosterCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (adminSifreyiGosterCBox.Checked)
            {
                sifreText.UseSystemPasswordChar = false;
            }
            else
            {
                sifreText.UseSystemPasswordChar = true;
            }
        }

        private void firmaEkleButon_Click(object sender, EventArgs e)
        {
            string ad = firmaEkleText.Text;          
            string user = firmaEkleText.Text;
            string pass = firmaEkleText.Text + "123";

            if (string.IsNullOrWhiteSpace(firmaEkleText.Text) )
            {
                MessageBox.Show("Firma adı Yazmadınız.");
                return;
            }

            Company yeniFirma = new Company(ad,user,pass);
            MessageBox.Show("Firma Eklendi!");
            business.Firmalar.Add(yeniFirma);

            GuncelleComboBox();
            
        }

        private void GuncelleComboBox()
        {
            firmalarList.Items.Clear();
            firmaEkleText.Text = "";           
            firmaCikartText.Text = "";            

            foreach (Company f in business.Firmalar)
            {
                firmalarList.Items.Add(f);
            }
        }

        private void firmaCikartButon_Click(object sender, EventArgs e)
        {
            string gelenAd = firmaCikartText.Text;

            if (string.IsNullOrWhiteSpace(firmaCikartText.Text))
            {
                MessageBox.Show("Firma adı Yazmadınız.");
                return;
            }


            for (int i = 0; i < business.Firmalar.Count; i++)
            {
                if (business.Firmalar[i].companyName == gelenAd ) 
                {
                    business.Firmalar.RemoveAt(i);
                    MessageBox.Show("Firma silindi!");
                    GuncelleComboBox();
                    break;
                }
            }
            MessageBox.Show("Firma Bulunamadı");


        }
    }
}

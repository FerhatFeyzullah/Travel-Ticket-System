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
        int aktifFirma;
        Company aktifComp;

        public void FirmScreen_Load(object sender, EventArgs e)
        {
            firmGirisPanel.Visible = true;
            panelFirmScreen.Visible = false;

            //firmGirisPanel.Visible = false;
            //panelFirmScreen.Visible = true;
            sifreText.UseSystemPasswordChar = true;
            GuncelleComboBox();


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
                    firmNameText.Text = Buisness.Firmalar[i].companyName;
                    //aktifFirma = i;

                    aktifComp = Buisness.Firmalar[i];
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

        private void aracEkleButton_Click(object sender, EventArgs e)
        {
            string gelenplaka = gelenPlakaEkleme.Text;
            string gelentip = cmbAracTipiEkle.SelectedItem?.ToString();


            if (string.IsNullOrWhiteSpace(gelenPlakaEkleme.Text) || string.IsNullOrWhiteSpace(cmbAracTipiEkle.Text))
            {
                MessageBox.Show("Lütfen Plaka Giriniz.");
                return;
            }
            Vehicle yeniArac = null;

            switch (gelentip)
            {
                case "Otobüs":
                    yeniArac = new Bus { Plaka = gelenplaka };
                    break;
                case "Uçak":
                    yeniArac = new Airplane { Plaka = gelenplaka };
                    break;
                case "Tren":
                    yeniArac = new Train { Plaka = gelenplaka };
                    break;
                default:
                    MessageBox.Show("Geçersiz araç tipi.");
                    return;
            }

            aktifComp.AracEkle(yeniArac);
            MessageBox.Show("Araç başarıyla eklendi!");





            GuncelleComboBox();




        }

        private void GuncelleComboBox()
        {
            cmbMevcutAraclarList.Items.Clear();
            gelenPlakaEkleme.Text = "";
            cmbAracTipiEkle.Text = "";

            cmbMevcutAraclarList.Items.Clear();
            foreach ( arac in aktifComp.Araclar)
            {
                cmbMevcutAraclar.Items.Add(arac); // ToString sayesinde tipiyle birlikte görünür
            }

            for(int j =0;j<aktifComp.ara)

            // Temizle
            txtPlaka.Clear();
            cmbAracTipi.SelectedIndex = -1;



        }

    }
}

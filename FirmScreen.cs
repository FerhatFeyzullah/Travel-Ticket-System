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
        Company aktifComp = new Company();
        Business business = new Business();

        public void FirmScreen_Load(object sender, EventArgs e)
        {
            firmGirisPanel.Visible = true;
            panelFirmScreen.Visible = false;

            //firmGirisPanel.Visible = false;
            //panelFirmScreen.Visible = true;
            sifreText.UseSystemPasswordChar = true;
            MevcutAraclariGuncelle();

        }

        private void firmGirisYapButton_Click(object sender, EventArgs e)
        {
            
            bool durum = false;
            for (int i = 0; i < business.Firmalar.Count; i++)
            {
                if (business.Firmalar[i].GirisYap(kullaniciAdiText.Text, sifreText.Text))
                {
                    panelFirmScreen.Visible = true;
                    firmGirisPanel.Visible = false;
                    firmNameText.Text = business.Firmalar[i].companyName;                   
                    aktifComp = business.Firmalar[i];
                    MevcutAraclariGuncelle();
                    MevcutSeferleriGuncelle();
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
                    yeniArac = new Bus { Plaka = gelenplaka + " ("+ gelentip + ")" };
                    break;
                case "Uçak":
                    yeniArac = new Airplane { Plaka = gelenplaka + " (" + gelentip + ")" };
                    break;
                case "Tren":
                    yeniArac = new Train { Plaka = gelenplaka + " (" + gelentip + ")" };
                    break;
                default:
                    MessageBox.Show("Geçersiz araç tipi.");
                    return;
            }

            aktifComp.AracEkle(yeniArac);
            MessageBox.Show("Araç başarıyla eklendi!");

            MevcutAraclariGuncelle();

        }
     
        private void MevcutAraclariGuncelle()
        {
            gelenPlakaEkleme.Text = "";
            cmbAracTipiEkle.Text = "";
            cmbMevcutAraclarCikarList.SelectedIndex = -1;
            cmbMevcutAraclarList.SelectedIndex = -1;
            cmbMevcutAraclarCikarList.Items.Clear();
            cmbMevcutAraclarList.Items.Clear();
            cmbAracTipiSeferEkle.Items.Clear();

            foreach (var arac in aktifComp.Araclar)
            {                
                cmbMevcutAraclarList.Items.Add(arac);
                cmbMevcutAraclarCikarList.Items.Add(arac);
                cmbAracTipiSeferEkle.Items.Add(arac);
                
            }
        }

        private void MevcutSeferleriGuncelle() 
        {
            seferNeredenEkle.Text = "";
            seferNereyeEkle.Text = "";
            cmbAracTipiSeferEkle.SelectedIndex = -1;
            cmbMevcutSeferlerdenCikar.SelectedIndex = -1;
            cmbMevcutSeferList.SelectedItem = -1;
            cmbMevcutSeferList.Items.Clear();
            cmbMevcutSeferlerdenCikar.Items.Clear();
            seferTarihEkle.Value = DateTime.Now;

            foreach (var sefer in aktifComp.Seferler)
            {
                cmbMevcutSeferList.Items.Add(sefer);
                cmbMevcutSeferlerdenCikar.Items.Add(sefer);
            }                     
        }       

        private void aracCikarButton_Click(object sender, EventArgs e)
        {
            Vehicle gelenAracCikarma = cmbMevcutAraclarCikarList.SelectedItem as Vehicle;

            for (int i = 0; i < aktifComp.Araclar.Count; i++)
            {
                if (aktifComp.Araclar[i] == gelenAracCikarma)
                {
                    aktifComp.Araclar.RemoveAt(i);
                    MessageBox.Show("Araç başarıyla silindi!");
                    MevcutAraclariGuncelle();
                    break;
                }
            }
        }

        private void seferEkleButon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(seferNeredenEkle.Text) || string.IsNullOrWhiteSpace(seferNereyeEkle.Text) ||
                string.IsNullOrWhiteSpace(cmbAracTipiSeferEkle.Text))
            {
                MessageBox.Show("Lütfen İstenen Bilgileri Giriniz.");
                return;
            }

            string gelenSeferNeredenEkle = seferNeredenEkle.Text;
            string gelenSeferNereyeEkle = seferNereyeEkle.Text;
            Vehicle gelenSeferAracEkle = cmbAracTipiSeferEkle.SelectedItem as Vehicle;
            DateTime gelentarihEkleDT = seferTarihEkle.Value;
          
            aktifComp.SeferEkle(gelenSeferNeredenEkle, gelenSeferNereyeEkle,gelentarihEkleDT,gelenSeferAracEkle,aktifComp.companyName);
            MevcutSeferleriGuncelle();
            MessageBox.Show("Sefer Eklenmiştir.");
        }

        private void seferCikartButon_Click(object sender, EventArgs e)
        {
            
            Sefer gelenSeferCikarCmb = cmbMevcutSeferlerdenCikar.SelectedItem as Sefer;


            for (int i = 0; i < aktifComp.Seferler.Count; i++)
            {
                
                if (aktifComp.Seferler[i]==gelenSeferCikarCmb)

                {
                    aktifComp.Seferler.RemoveAt(i);
                    MessageBox.Show("Sefer başarıyla silindi!");
                    MevcutSeferleriGuncelle();
                    break;
                }
            }
            
        }

        
    }
}

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

namespace Travel_Ticket_System
{
    public partial class PassengerScreen : Form
    {
        List<Sefer> BulunanSeferler = new List<Sefer>();
        string secilenTip;
        Business buis =new Business();
        Company comp =new Company();
        Sefer sefer = new Sefer();
        
        public PassengerScreen()
        {
            InitializeComponent();
            

        }

        private void dateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PassengerScreen_Load(object sender, EventArgs e)
        {
            seferGosterPanel.Visible = false;
        }

        private void Otobus_Click(object sender, EventArgs e)
        {
            secilenTip = "Bus";
        }

        private void Ucak_Click(object sender, EventArgs e)
        {
            secilenTip = "Airplane";
        }

        private void Tren_Click(object sender, EventArgs e)
        {
            secilenTip = "Train";
        }

        private void filtreleButton_Click(object sender, EventArgs e)
        {
            BulunanSeferler.Clear();
            string nereden = cmbNereden.SelectedItem?.ToString();
            string nereye = cmbNereye.SelectedItem?.ToString();
            DateTime secilentarih = dtpSeferTarihi.Value.Date;

            for (int i = 0; i < buis.Firmalar.Count; i++)
            { 
                comp = buis.Firmalar[i];
                for (int j = 0; j < comp.Seferler.Count; j++)
                {

                sefer = comp.Seferler[j];

                    if(sefer.Arac.GetType().Name == secilenTip &&
                       sefer.Nereden == nereden &&
                       sefer.Nereye == nereye &&
                       sefer.Tarih.Date == secilentarih)
                    {
                    
                        BulunanSeferler.Add(sefer);
                    }

                }
            }

            BulunanSeferleriGuncelle();
            SeferleriListele();
            seferGosterPanel.Visible = true;
        }

        private void BulunanSeferleriGuncelle()
        {
            cmbNereden.SelectedIndex = -1;
            cmbNereye.SelectedIndex = -1;

            cmbBulunanSeferler.Items.Clear();

            foreach (var sefer in BulunanSeferler)
            {
                cmbBulunanSeferler.Items.Add(sefer);
            
            }
        }

        

        public void SeferleriListele()
        {

          

           


            seferGosterPanel.Controls.Clear();

            int yOffset = 50;

            foreach (Sefer sefer in BulunanSeferler)
            {
                

                // Yeni panel oluştur
                Panel p = new Panel();
                p.Size = new Size(600, 100);
                p.Location = new Point(10, yOffset);
                p.BorderStyle = BorderStyle.FixedSingle;

                // Label - Sefer bilgisi
                Label lbl = new Label();
                lbl.Text = $"→ {sefer.Nereden} - {sefer.Nereye} | Tarih: {sefer.Tarih.ToShortDateString()} {sefer.Tarih.ToShortTimeString()} | Plaka: {sefer.Arac.Plaka} | {sefer.FirmaIsmi}";
                lbl.Location = new Point(10, 10);
                lbl.AutoSize = true;
                p.Controls.Add(lbl);

                // Bilet Al Butonu (istersen)
                Button btnBilet = new Button();
                btnBilet.Text = "Bilet Al";
                btnBilet.Location = new Point(10, 40);
                btnBilet.Tag = sefer; // Bu butonun içine o seferi iliştiriyoruz
                btnBilet.Click += BiletAlTiklandi;
                p.Controls.Add(btnBilet);

                // Paneli ana panel'e ekle
                seferGosterPanel.Controls.Add(p);

                yOffset += 110; // Sonraki panelin y'si
            }
        }

        private void BiletAlTiklandi(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Sefer secilenSefer = btn.Tag as Sefer;

            // Burada istersen bilet alma formu açarsın
            MessageBox.Show($"Bilet alındı:\n{secilenSefer.Nereden} → {secilenSefer.Nereye}");
        }

        private void GeriDonTiklandi(object sender, EventArgs e)
        {
            
            seferGosterPanel.Visible = false;
            biletAramaPanel.Visible = true;

            
            seferGosterPanel.Controls.Clear();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace proje2
{
    public partial class FormKullaniciGiris : Form
    {
        public FormKullaniciGiris()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {

            if (KullaniciGiris(txtKullaniciAdi.Text, txtSifre.Text) == 1)
            {
                 MessageBox.Show("Giriş Başarılı");
                //urunEkle ekle = new urunEkle();
                //ekle.Show();

                #region Veri Tabanına Ekleme Sayfasına Gidiş Butonu
                Button btnData = new Button();
                btnData.Name = "Data";
                btnData.Text = "Database";
                btnData.Size = new Size(280, 100);
                btnData.Margin = new Padding(3, 3, 3, 3);
                btnData.Location = new Point(703,480);
                btnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                Controls.Add(btnData);
                btnData.Click += BttnData_Click;
                #endregion

                #region Muhasebe Sayfasına Gidiş Butonu
                Button btnMuhasebe = new Button();
                btnMuhasebe.Name = "Muhasebe";
                btnMuhasebe.Text = "Muhasebe";
                btnMuhasebe.Size = new Size(300, 100);
                btnMuhasebe.Margin = new Padding(3, 3, 3, 3);
                btnMuhasebe.Location = new Point(993, 480);
                btnMuhasebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                Controls.Add(btnMuhasebe);
                btnMuhasebe.Click += BtnMuhasebe_Click;
                #endregion
                
            }
            else
            {
                MessageBox.Show("Giriş Başarısız. Lütfen tekrar deneyiniz.");
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
            }
        }

        private void BtnMuhasebe_Click(object sender, EventArgs e)
        {
            muhasebe karZarar = new muhasebe();
            karZarar.Show();
        }

        private void BttnData_Click(object sender, EventArgs e)
        {
            urunEkle ekle = new urunEkle();
            ekle.Show();
        }

        

        private void FormKullaniciGiris_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(BtnUrunGoster, "Ürünlerimiz İçin Lütfen Tıklayınız.");
        }
        #region Kullanici Giris 
        public int KullaniciGiris(string KullaniciAdi, string Sifre)
        {
            int sonuc = 0;
            string connectionstr = "SERVER=localhost;DATABASE=proje2;UID=root;PWD=Sila12";
            using (var connection = new MySqlConnection(connectionstr))
            {
                using (var cmd = new MySqlCommand($"SELECT kullaniciAdi,sifre FROM giris WHERE kullaniciAdi='{KullaniciAdi}' AND sifre='{Sifre}' ", connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {
                            string girilenKullanici = dtr["kullaniciAdi"].ToString();
                            string girilenSifre = dtr["sifre"].ToString();
                            if (girilenKullanici == KullaniciAdi && girilenSifre == Sifre)
                                sonuc = 1;
                            else
                                sonuc = 0;
                        }
                    }
                    catch
                    {
                        sonuc = 0;
                    }
                    
                }

            }
            return sonuc;
        }
        #endregion

        private void BtnUrunGoster_Click(object sender, EventArgs e)
        {
           

            Mobilya goster = new Mobilya();
            goster.Show();
            this.Hide();
           // this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}






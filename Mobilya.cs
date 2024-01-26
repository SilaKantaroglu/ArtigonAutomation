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
using System.IO;
using System.Drawing.Imaging;



namespace proje2
{
    public partial class Mobilya : Form
    {
        public Mobilya()
        {
            InitializeComponent();
        }
        string connectionstr = "SERVER=localhost;DATABASE=proje2;UID=root;PWD=Sila12";



        private void Mobilya_Load(object sender, EventArgs e)
        {
            using (var connect = new MySqlConnection(connectionstr))
            {
                using (var myAdap = new MySqlDataAdapter("SELECT * FROM mobilya WHERE MobilyaTur = 'Koltuk' ", connect))
                {
                    try
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        myAdap.Fill(dt);
                        dgrMobilya.DataSource = dt;

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

            }
        }

        #region Ürün Grupları
        private void BtnKoltuk_Click(object sender, EventArgs e)
        {
            using (var connect = new MySqlConnection(connectionstr))
            {
                using (var myAdap = new MySqlDataAdapter("SELECT * FROM mobilya WHERE MobilyaTur = 'Koltuk' ", connect))
                {
                    try
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        myAdap.Fill(dt);
                        dgrMobilya.DataSource = dt;

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

            }
        }

        private void BtnHalı_Click(object sender, EventArgs e)
        {
            using (var connect = new MySqlConnection(connectionstr))
            {
                using (var myAdap = new MySqlDataAdapter("SELECT * FROM mobilya WHERE MobilyaTur = 'Halı' ", connect))
                {
                    try
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        myAdap.Fill(dt);
                        dgrMobilya.DataSource = dt;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void BtnDolap_Click(object sender, EventArgs e)
        {
            using (var connect = new MySqlConnection(connectionstr))
            {
                using (var myAdap = new MySqlDataAdapter("SELECT * FROM mobilya WHERE MobilyaTur = 'Dolap' ", connect))
                {
                    try
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        myAdap.Fill(dt);
                        dgrMobilya.DataSource = dt;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void BtnMasa_Click(object sender, EventArgs e)
        {
            using (var connect = new MySqlConnection(connectionstr))
            {
                using (var myAdap = new MySqlDataAdapter("SELECT * FROM mobilya WHERE MobilyaTur = 'Masa' ", connect))
                {
                    try
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        myAdap.Fill(dt);
                        dgrMobilya.DataSource = dt;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void BtbPerde_Click(object sender, EventArgs e)
        {
            using (var connect = new MySqlConnection(connectionstr))
            {
                using (var myAdap = new MySqlDataAdapter("SELECT * FROM mobilya WHERE MobilyaTur = 'Perde' ", connect))
                {
                    try
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        myAdap.Fill(dt);
                        dgrMobilya.DataSource = dt;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void BtnSandalye_Click(object sender, EventArgs e)
        {
            using (var connect = new MySqlConnection(connectionstr))
            {
                using (var myAdap = new MySqlDataAdapter("SELECT * FROM mobilya WHERE MobilyaTur = 'Sandalye' ", connect))
                {
                    try
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        myAdap.Fill(dt);
                        dgrMobilya.DataSource = dt;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void BtnTul_Click(object sender, EventArgs e)
        {
            using (var connect = new MySqlConnection(connectionstr))
            {
                using (var myAdap = new MySqlDataAdapter("SELECT * FROM mobilya WHERE MobilyaTur = 'Tul' ", connect))
                {
                    try
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        myAdap.Fill(dt);
                        dgrMobilya.DataSource = dt;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void BtnYatak_Click(object sender, EventArgs e)
        {
            using (var connect = new MySqlConnection(connectionstr))
            {
                using (var myAdap = new MySqlDataAdapter("SELECT * FROM mobilya WHERE MobilyaTur = 'Yatak' ", connect))
                {
                    try
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        myAdap.Fill(dt);
                        dgrMobilya.DataSource = dt;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        #endregion

        private void dgrMobilya_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var connect = new MySqlConnection(connectionstr);

            connect.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM mobilya WHERE MobilyaId= '" +
                int.Parse(dgrMobilya.CurrentRow.Cells[0].Value.ToString()) + "'", connect);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr["Gorsel"] != null)
                {
                    byte[] images = new byte[0];
                    images = (byte[])dr["Gorsel"];
                    MemoryStream ms = new MemoryStream(images);
                    pbGorsel.Image = Image.FromStream(ms);
                    dr.Close();
                    cmd.Dispose();
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("Görsel bulunamadı.");
                }
            }
            connect.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormKullaniciGiris AnaSayfa = new FormKullaniciGiris();
            AnaSayfa.Show();
            this.Close();
        }

        private void BtnSepetEkle_Click(object sender, EventArgs e)
        {
            sepet sepetiGoster = new sepet();
            sepetiGoster.Turu = dgrMobilya.CurrentRow.Cells[1].Value.ToString();
            sepetiGoster.Id = dgrMobilya.CurrentRow.Cells[0].Value.ToString();
            sepetiGoster.Markasi = dgrMobilya.CurrentRow.Cells[2].Value.ToString();
            sepetiGoster.Fiyati = dgrMobilya.CurrentRow.Cells[3].Value.ToString();
            sepetiGoster.AlisFiyati = dgrMobilya.CurrentRow.Cells[4].Value.ToString();
            
            sepetiGoster.Show();
            this.Close();
        }

        private void dgrMobilya_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

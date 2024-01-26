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
    public partial class sepet : Form
    {
        
        //string connectionstr = "SERVER=localhost;DATABASE=proje2;UID=root;PWD=Sila12";
        public sepet()
        {
            InitializeComponent();
        }
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataAdapter dtadap;

        private void Getir()
        {
            connection = new MySqlConnection("SERVER=localhost;DATABASE=proje2;UID=root;PWD=Sila12");
            connection.Open();
            dtadap = new MySqlDataAdapter("SELECT tursepet,markasepet,fiyatsepet,idsepet,AlisFiyat FROM sepet", connection);
            DataTable TblSepet = new DataTable();
            dtadap.Fill(TblSepet);
            dgrSepet.DataSource = TblSepet;
            connection.Close();
        }
        
        public string Turu, Markasi, Fiyati, Id,AlisFiyati;

        private void btnEkle_Click(object sender, EventArgs e)
        {
           
            string query = "INSERT INTO sepet(tursepet,markasepet,fiyatsepet,AlisFiyat,idsepet) VALUES (@tursepet,@markasepet,@fiyatsepet,@AlisFiyat,@idsepet) ";
            cmd =new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@tursepet", textBoxTur.Text);
            cmd.Parameters.AddWithValue("@markasepet", textBoxMarkasi.Text);
            cmd.Parameters.AddWithValue("@fiyatsepet", textBoxFiyati.Text);
            cmd.Parameters.AddWithValue("@idsepet", textBoxId.Text);
            cmd.Parameters.AddWithValue("@AlisFiyat", textBoxAlisF.Text);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            Getir();
            textBoxFiyati.Clear();
            textBoxMarkasi.Clear();
            textBoxId.Clear();
            textBoxTur.Clear();
            textBoxAlisF.Clear();
            textBoxMarkasi.Enabled = false;
            textBoxFiyati.Enabled = false;
            textBoxTur.Enabled = false;
          
           
           // textBoxId.Enabled = false;
        }

       

        private void btnSil_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM sepet WHERE idsepet=@idsepet";
            cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@idsepet", Convert.ToInt32(textBoxId.Text));
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            Getir();
            textBoxFiyati.Clear();
            textBoxAlisF.Clear();
            textBoxMarkasi.Clear();
            textBoxId.Clear();
            textBoxTur.Clear();
            textBoxMarkasi.Enabled = false;
            textBoxFiyati.Enabled = false;
            textBoxTur.Enabled = false;

        }

        private void dgrSepet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Mobilya MobilyaDon = new Mobilya();
            MobilyaDon.Show();
            this.Close();
        }
        
        private void sepet_Load(object sender, EventArgs e)
        {
            textBoxTur.Text = Turu;
            textBoxId.Text = Id;
            textBoxMarkasi.Text = Markasi;
            textBoxFiyati.Text = Fiyati;
            textBoxAlisF.Text = AlisFiyati;
            Getir();
           
          
        }
    }
}

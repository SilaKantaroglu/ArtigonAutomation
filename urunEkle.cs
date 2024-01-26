using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proje2
{
    public partial class urunEkle : Form
    {
        public urunEkle()
        {
            InitializeComponent();
        }
        string imagePath;

        private void Uruneklebtn_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=proje2;UID=root;PWD=Sila12");
            string query = "insert into mobilya(MobilyaTur, Marka, Fiyat, AlisFiyat ) values(@p1, @p2, @p3, @p4)";
            cmd = new MySqlCommand(query, connection);
            
            cmd.Parameters.AddWithValue("@p1", TxtUrunGrubu.Text);
            cmd.Parameters.AddWithValue("@p2", TxtMarka.Text);         
            cmd.Parameters.AddWithValue("@p3", TxtFiyat.Text);
            cmd.Parameters.AddWithValue("@p4", TxtAlisFiyat.Text);

            FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] image = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            MySqlCommand kmt = new MySqlCommand("insert into mobilya(gorsel) values (@p5)", connection);
            kmt.Parameters.Add("@p5", MySqlDbType.MediumBlob, image.Length).Value = image;
            connection.Open();
            int v = cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ürün Başarıyla Eklendi");
            TxtUrunGrubu.Clear();

        }
        

        private void Btngozat_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Jpeg Dosyası(*.jpg)|.jpg|png (*.png)|.png|Jpeg (*.jpeg)|.jpeg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbresimgozat.Image = Image.FromFile(openFileDialog1.FileName);
                imagePath = openFileDialog1.FileName.ToString();
            }
            //pbresimgozat.ImageLocation = openFileDialog1.FileName;
            //TxtGorsel.Text = openFileDialog1.FileName;
        }

        //private void urunEkle_Load(object sender, EventArgs e)
        //{

        //}
    }
}

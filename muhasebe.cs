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
    public partial class muhasebe : Form
    {
        public muhasebe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string connectionstr = "SERVER=localhost;DATABASE=proje2;UID=root;PWD=Sila12";

        private void dgrMuhasebe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void muhasebe_Load(object sender, EventArgs e)
        {
            using (var connect = new MySqlConnection(connectionstr))
            {
                using (var myAdap = new MySqlDataAdapter("select (fiyatsepet - AlisFiyat) as Kar , idsepet, tursepet,markasepet From sepet;    ", connect))
                {
                    try
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        myAdap.Fill(dt);
                        dgrMuhasebe.DataSource = dt;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
    }
}

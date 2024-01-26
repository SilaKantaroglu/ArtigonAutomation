
namespace proje2
{
    partial class FormKullaniciGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKullaniciGiris));
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnUrunGoster = new System.Windows.Forms.Button();
            this.urunler = new System.Windows.Forms.Button();
            this.baslik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(815, 335);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(287, 36);
            this.txtSifre.TabIndex = 6;
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.Honeydew;
            this.BtnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGiris.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnGiris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnGiris.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGiris.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtnGiris.Location = new System.Drawing.Point(851, 377);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnGiris.Size = new System.Drawing.Size(213, 54);
            this.BtnGiris.TabIndex = 4;
            this.BtnGiris.Text = "GİRİŞ";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(815, 285);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(287, 32);
            this.txtKullaniciAdi.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnUrunGoster);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Location = new System.Drawing.Point(60, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 328);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARTİGON";
            // 
            // BtnUrunGoster
            // 
            this.BtnUrunGoster.BackColor = System.Drawing.Color.Transparent;
            this.BtnUrunGoster.BackgroundImage = global::proje2.Properties.Resources.artigon;
            this.BtnUrunGoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUrunGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUrunGoster.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnUrunGoster.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnUrunGoster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnUrunGoster.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnUrunGoster.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunGoster.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnUrunGoster.Location = new System.Drawing.Point(-8, 29);
            this.BtnUrunGoster.Name = "BtnUrunGoster";
            this.BtnUrunGoster.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnUrunGoster.Size = new System.Drawing.Size(589, 293);
            this.BtnUrunGoster.TabIndex = 18;
            this.BtnUrunGoster.UseVisualStyleBackColor = false;
            this.BtnUrunGoster.Click += new System.EventHandler(this.BtnUrunGoster_Click);
            // 
            // urunler
            // 
            this.urunler.Location = new System.Drawing.Point(0, 0);
            this.urunler.Name = "urunler";
            this.urunler.Size = new System.Drawing.Size(75, 23);
            this.urunler.TabIndex = 0;
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.baslik.Font = new System.Drawing.Font("Rockwell", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslik.ForeColor = System.Drawing.SystemColors.ControlText;
            this.baslik.Location = new System.Drawing.Point(302, 15);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(771, 56);
            this.baslik.TabIndex = 14;
            this.baslik.Text = "ARTİGON MİMARLIK STÜDYOSU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proje2.Properties.Resources.artigon;
            this.pictureBox1.Location = new System.Drawing.Point(120, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::proje2.Properties.Resources.key_icon;
            this.pictureBox4.Location = new System.Drawing.Point(690, 274);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(156, 161);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::proje2.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(739, 263);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // FormKullaniciGiris
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::proje2.Properties.Resources.Ekran_Görüntüsü__46_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1336, 674);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnGiris);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.FormKullaniciGiris_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button urunler;
        private System.Windows.Forms.Button BtnUrunGoster;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}


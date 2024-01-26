
namespace proje2
{
    partial class Mobilya
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mobilya));
            this.TxtMobilya = new System.Windows.Forms.Label();
            this.dgrMobilya = new System.Windows.Forms.DataGridView();
            this.BtnKoltuk = new System.Windows.Forms.Button();
            this.BtnHalı = new System.Windows.Forms.Button();
            this.BtnDolap = new System.Windows.Forms.Button();
            this.BtnMasa = new System.Windows.Forms.Button();
            this.BtbPerde = new System.Windows.Forms.Button();
            this.BtnTul = new System.Windows.Forms.Button();
            this.BtnSandalye = new System.Windows.Forms.Button();
            this.BtnYatak = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.pbGorsel = new System.Windows.Forms.PictureBox();
            this.BtnSepetEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMobilya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGorsel)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtMobilya
            // 
            resources.ApplyResources(this.TxtMobilya, "TxtMobilya");
            this.TxtMobilya.BackColor = System.Drawing.Color.Transparent;
            this.TxtMobilya.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TxtMobilya.Name = "TxtMobilya";
            // 
            // dgrMobilya
            // 
            this.dgrMobilya.BackgroundColor = System.Drawing.Color.Snow;
            this.dgrMobilya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgrMobilya, "dgrMobilya");
            this.dgrMobilya.Name = "dgrMobilya";
            this.dgrMobilya.RowTemplate.Height = 24;
            this.dgrMobilya.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrMobilya_CellClick);
            this.dgrMobilya.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrMobilya_CellContentClick);
            // 
            // BtnKoltuk
            // 
            resources.ApplyResources(this.BtnKoltuk, "BtnKoltuk");
            this.BtnKoltuk.Name = "BtnKoltuk";
            this.BtnKoltuk.UseVisualStyleBackColor = true;
            this.BtnKoltuk.Click += new System.EventHandler(this.BtnKoltuk_Click);
            // 
            // BtnHalı
            // 
            resources.ApplyResources(this.BtnHalı, "BtnHalı");
            this.BtnHalı.Name = "BtnHalı";
            this.BtnHalı.UseVisualStyleBackColor = true;
            this.BtnHalı.Click += new System.EventHandler(this.BtnHalı_Click);
            // 
            // BtnDolap
            // 
            resources.ApplyResources(this.BtnDolap, "BtnDolap");
            this.BtnDolap.Name = "BtnDolap";
            this.BtnDolap.UseVisualStyleBackColor = true;
            this.BtnDolap.Click += new System.EventHandler(this.BtnDolap_Click);
            // 
            // BtnMasa
            // 
            resources.ApplyResources(this.BtnMasa, "BtnMasa");
            this.BtnMasa.Name = "BtnMasa";
            this.BtnMasa.UseVisualStyleBackColor = true;
            this.BtnMasa.Click += new System.EventHandler(this.BtnMasa_Click);
            // 
            // BtbPerde
            // 
            resources.ApplyResources(this.BtbPerde, "BtbPerde");
            this.BtbPerde.Name = "BtbPerde";
            this.BtbPerde.UseVisualStyleBackColor = true;
            this.BtbPerde.Click += new System.EventHandler(this.BtbPerde_Click);
            // 
            // BtnTul
            // 
            resources.ApplyResources(this.BtnTul, "BtnTul");
            this.BtnTul.Name = "BtnTul";
            this.BtnTul.UseVisualStyleBackColor = true;
            this.BtnTul.Click += new System.EventHandler(this.BtnTul_Click);
            // 
            // BtnSandalye
            // 
            resources.ApplyResources(this.BtnSandalye, "BtnSandalye");
            this.BtnSandalye.Name = "BtnSandalye";
            this.BtnSandalye.UseVisualStyleBackColor = true;
            this.BtnSandalye.Click += new System.EventHandler(this.BtnSandalye_Click);
            // 
            // BtnYatak
            // 
            resources.ApplyResources(this.BtnYatak, "BtnYatak");
            this.BtnYatak.Name = "BtnYatak";
            this.BtnYatak.UseVisualStyleBackColor = true;
            this.BtnYatak.Click += new System.EventHandler(this.BtnYatak_Click);
            // 
            // btnGeri
            // 
            resources.ApplyResources(this.btnGeri, "btnGeri");
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // pbGorsel
            // 
            this.pbGorsel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pbGorsel, "pbGorsel");
            this.pbGorsel.Name = "pbGorsel";
            this.pbGorsel.TabStop = false;
            // 
            // BtnSepetEkle
            // 
            this.BtnSepetEkle.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.BtnSepetEkle, "BtnSepetEkle");
            this.BtnSepetEkle.Name = "BtnSepetEkle";
            this.BtnSepetEkle.UseVisualStyleBackColor = false;
            this.BtnSepetEkle.Click += new System.EventHandler(this.BtnSepetEkle_Click);
            // 
            // Mobilya
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = global::proje2.Properties.Resources.Ekran_görüntüsü_2022_06_23_004105;
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.BtnYatak);
            this.Controls.Add(this.BtnSandalye);
            this.Controls.Add(this.BtnTul);
            this.Controls.Add(this.BtbPerde);
            this.Controls.Add(this.BtnMasa);
            this.Controls.Add(this.BtnDolap);
            this.Controls.Add(this.BtnHalı);
            this.Controls.Add(this.BtnKoltuk);
            this.Controls.Add(this.BtnSepetEkle);
            this.Controls.Add(this.pbGorsel);
            this.Controls.Add(this.dgrMobilya);
            this.Controls.Add(this.TxtMobilya);
            this.DoubleBuffered = true;
            this.Name = "Mobilya";
            this.Load += new System.EventHandler(this.Mobilya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrMobilya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGorsel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtMobilya;
        private System.Windows.Forms.DataGridView dgrMobilya;
        private System.Windows.Forms.PictureBox pbGorsel;
        private System.Windows.Forms.Button BtnKoltuk;
        private System.Windows.Forms.Button BtnHalı;
        private System.Windows.Forms.Button BtnDolap;
        private System.Windows.Forms.Button BtnMasa;
        private System.Windows.Forms.Button BtbPerde;
        private System.Windows.Forms.Button BtnTul;
        private System.Windows.Forms.Button BtnSandalye;
        private System.Windows.Forms.Button BtnYatak;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button BtnSepetEkle;
    }
}
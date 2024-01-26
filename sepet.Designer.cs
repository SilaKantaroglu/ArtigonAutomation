
namespace proje2
{
    partial class sepet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sepet));
            this.textBoxTur = new System.Windows.Forms.TextBox();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.textBoxFiyati = new System.Windows.Forms.TextBox();
            this.textBoxMarkasi = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgrSepet = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAlisF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTur
            // 
            resources.ApplyResources(this.textBoxTur, "textBoxTur");
            this.textBoxTur.Name = "textBoxTur";
            // 
            // lblTur
            // 
            resources.ApplyResources(this.lblTur, "lblTur");
            this.lblTur.BackColor = System.Drawing.Color.Transparent;
            this.lblTur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTur.Name = "lblTur";
            // 
            // lblid
            // 
            resources.ApplyResources(this.lblid, "lblid");
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblid.Name = "lblid";
            // 
            // lblMarka
            // 
            resources.ApplyResources(this.lblMarka, "lblMarka");
            this.lblMarka.BackColor = System.Drawing.Color.Transparent;
            this.lblMarka.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMarka.Name = "lblMarka";
            // 
            // l
            // 
            resources.ApplyResources(this.l, "l");
            this.l.BackColor = System.Drawing.Color.Transparent;
            this.l.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l.Name = "l";
            // 
            // textBoxFiyati
            // 
            resources.ApplyResources(this.textBoxFiyati, "textBoxFiyati");
            this.textBoxFiyati.Name = "textBoxFiyati";
            // 
            // textBoxMarkasi
            // 
            resources.ApplyResources(this.textBoxMarkasi, "textBoxMarkasi");
            this.textBoxMarkasi.Name = "textBoxMarkasi";
            // 
            // textBoxId
            // 
            resources.ApplyResources(this.textBoxId, "textBoxId");
            this.textBoxId.Name = "textBoxId";
            // 
            // btnGeri
            // 
            resources.ApplyResources(this.btnGeri, "btnGeri");
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.Image = global::proje2.Properties.Resources._353403_cart_icon;
            resources.ApplyResources(this.btnEkle, "btnEkle");
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgrSepet
            // 
            this.dgrSepet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrSepet.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgrSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgrSepet, "dgrSepet");
            this.dgrSepet.Name = "dgrSepet";
            this.dgrSepet.RowTemplate.Height = 24;
            this.dgrSepet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrSepet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrSepet_CellContentClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSil, "btnSil");
            this.btnSil.Image = global::proje2.Properties.Resources._211934_trash_icon;
            this.btnSil.Name = "btnSil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            // 
            // textBoxAlisF
            // 
            resources.ApplyResources(this.textBoxAlisF, "textBoxAlisF");
            this.textBoxAlisF.Name = "textBoxAlisF";
            // 
            // sepet
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proje2.Properties.Resources.Ekran_görüntüsü_2022_06_24_034923;
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgrSepet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxMarkasi);
            this.Controls.Add(this.textBoxFiyati);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.l);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.textBoxTur);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAlisF);
            this.DoubleBuffered = true;
            this.Name = "sepet";
            this.Load += new System.EventHandler(this.sepet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrSepet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTur;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox textBoxFiyati;
        private System.Windows.Forms.TextBox textBoxMarkasi;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgrSepet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAlisF;
    }
}

namespace proje2
{
    partial class urunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMarka = new System.Windows.Forms.TextBox();
            this.TxtAlisFiyat = new System.Windows.Forms.TextBox();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.Uruneklebtn = new System.Windows.Forms.Button();
            this.TxtGorsel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUrunGrubu = new System.Windows.Forms.TextBox();
            this.Btngozat = new System.Windows.Forms.Button();
            this.pbresimgozat = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbresimgozat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Name = "label4";
            // 
            // TxtMarka
            // 
            this.TxtMarka.BackColor = System.Drawing.Color.LightCyan;
            resources.ApplyResources(this.TxtMarka, "TxtMarka");
            this.TxtMarka.Name = "TxtMarka";
            // 
            // TxtAlisFiyat
            // 
            this.TxtAlisFiyat.BackColor = System.Drawing.Color.LightCyan;
            resources.ApplyResources(this.TxtAlisFiyat, "TxtAlisFiyat");
            this.TxtAlisFiyat.Name = "TxtAlisFiyat";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.BackColor = System.Drawing.Color.LightCyan;
            resources.ApplyResources(this.TxtFiyat, "TxtFiyat");
            this.TxtFiyat.Name = "TxtFiyat";
            // 
            // Uruneklebtn
            // 
            this.Uruneklebtn.BackColor = System.Drawing.Color.LightCyan;
            resources.ApplyResources(this.Uruneklebtn, "Uruneklebtn");
            this.Uruneklebtn.Name = "Uruneklebtn";
            this.Uruneklebtn.UseVisualStyleBackColor = false;
            this.Uruneklebtn.Click += new System.EventHandler(this.Uruneklebtn_Click);
            // 
            // TxtGorsel
            // 
            this.TxtGorsel.BackColor = System.Drawing.Color.LightCyan;
            resources.ApplyResources(this.TxtGorsel, "TxtGorsel");
            this.TxtGorsel.Name = "TxtGorsel";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Name = "label5";
            // 
            // TxtUrunGrubu
            // 
            this.TxtUrunGrubu.BackColor = System.Drawing.Color.LightCyan;
            resources.ApplyResources(this.TxtUrunGrubu, "TxtUrunGrubu");
            this.TxtUrunGrubu.Name = "TxtUrunGrubu";
            // 
            // Btngozat
            // 
            resources.ApplyResources(this.Btngozat, "Btngozat");
            this.Btngozat.Name = "Btngozat";
            this.Btngozat.UseVisualStyleBackColor = true;
            this.Btngozat.Click += new System.EventHandler(this.Btngozat_Click_1);
            // 
            // pbresimgozat
            // 
            this.pbresimgozat.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pbresimgozat, "pbresimgozat");
            this.pbresimgozat.Name = "pbresimgozat";
            this.pbresimgozat.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // urunEkle
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proje2.Properties.Resources.Ekran_görüntüsü_2022_06_25_015826;
            this.Controls.Add(this.pbresimgozat);
            this.Controls.Add(this.Btngozat);
            this.Controls.Add(this.TxtUrunGrubu);
            this.Controls.Add(this.TxtGorsel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Uruneklebtn);
            this.Controls.Add(this.TxtFiyat);
            this.Controls.Add(this.TxtAlisFiyat);
            this.Controls.Add(this.TxtMarka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "urunEkle";
            ((System.ComponentModel.ISupportInitialize)(this.pbresimgozat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMarka;
        private System.Windows.Forms.TextBox TxtAlisFiyat;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.Button Uruneklebtn;
        private System.Windows.Forms.TextBox TxtGorsel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtUrunGrubu;
        private System.Windows.Forms.Button Btngozat;
        private System.Windows.Forms.PictureBox pbresimgozat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
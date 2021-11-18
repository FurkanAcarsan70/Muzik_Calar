namespace Müzik_Çalar
{
    partial class MüzikÇalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüzikÇalar));
            this.wdpMüzik = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstMüzik = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSesAzalt = new System.Windows.Forms.Button();
            this.btnSesArttır = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnŞarkıyıTemizle = new System.Windows.Forms.Button();
            this.btnListeyiTemizle = new System.Windows.Forms.Button();
            this.btnListeOluştur = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnİleriSar = new System.Windows.Forms.Button();
            this.btnGeriSar = new System.Windows.Forms.Button();
            this.btnÖncekiŞarkı = new System.Windows.Forms.Button();
            this.btnSonrakiŞarkı = new System.Windows.Forms.Button();
            this.btnDevamEt = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnDuraklat = new System.Windows.Forms.Button();
            this.btnOynat = new System.Windows.Forms.Button();
            this.lblŞarkıİsmi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wdpMüzik)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // wdpMüzik
            // 
            this.wdpMüzik.Dock = System.Windows.Forms.DockStyle.Top;
            this.wdpMüzik.Enabled = true;
            this.wdpMüzik.Location = new System.Drawing.Point(0, 0);
            this.wdpMüzik.Name = "wdpMüzik";
            this.wdpMüzik.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wdpMüzik.OcxState")));
            this.wdpMüzik.Size = new System.Drawing.Size(691, 230);
            this.wdpMüzik.TabIndex = 2;
            // 
            // lstMüzik
            // 
            this.lstMüzik.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstMüzik.FormattingEnabled = true;
            this.lstMüzik.Location = new System.Drawing.Point(691, 0);
            this.lstMüzik.Name = "lstMüzik";
            this.lstMüzik.Size = new System.Drawing.Size(245, 463);
            this.lstMüzik.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSesAzalt);
            this.groupBox1.Controls.Add(this.btnSesArttır);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ses Seviyesi";
            // 
            // btnSesAzalt
            // 
            this.btnSesAzalt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSesAzalt.Location = new System.Drawing.Point(106, 16);
            this.btnSesAzalt.Name = "btnSesAzalt";
            this.btnSesAzalt.Size = new System.Drawing.Size(91, 141);
            this.btnSesAzalt.TabIndex = 1;
            this.btnSesAzalt.Text = "-";
            this.btnSesAzalt.UseVisualStyleBackColor = true;
            this.btnSesAzalt.Click += new System.EventHandler(this.btnSesAzalt_Click);
            // 
            // btnSesArttır
            // 
            this.btnSesArttır.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSesArttır.Location = new System.Drawing.Point(3, 16);
            this.btnSesArttır.Name = "btnSesArttır";
            this.btnSesArttır.Size = new System.Drawing.Size(103, 141);
            this.btnSesArttır.TabIndex = 0;
            this.btnSesArttır.Text = "+";
            this.btnSesArttır.UseVisualStyleBackColor = true;
            this.btnSesArttır.Click += new System.EventHandler(this.btnSesArttır_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnŞarkıyıTemizle);
            this.groupBox2.Controls.Add(this.btnListeyiTemizle);
            this.groupBox2.Controls.Add(this.btnListeOluştur);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(200, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 160);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oynatma Listesi";
            // 
            // btnŞarkıyıTemizle
            // 
            this.btnŞarkıyıTemizle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnŞarkıyıTemizle.Location = new System.Drawing.Point(3, 112);
            this.btnŞarkıyıTemizle.Name = "btnŞarkıyıTemizle";
            this.btnŞarkıyıTemizle.Size = new System.Drawing.Size(485, 43);
            this.btnŞarkıyıTemizle.TabIndex = 2;
            this.btnŞarkıyıTemizle.Text = "Şarkıyı Sil";
            this.btnŞarkıyıTemizle.UseVisualStyleBackColor = true;
            this.btnŞarkıyıTemizle.Click += new System.EventHandler(this.btnŞarkıyıTemizle_Click);
            // 
            // btnListeyiTemizle
            // 
            this.btnListeyiTemizle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListeyiTemizle.Location = new System.Drawing.Point(3, 63);
            this.btnListeyiTemizle.Name = "btnListeyiTemizle";
            this.btnListeyiTemizle.Size = new System.Drawing.Size(485, 49);
            this.btnListeyiTemizle.TabIndex = 1;
            this.btnListeyiTemizle.Text = "Oynatma Listesini Temizle";
            this.btnListeyiTemizle.UseVisualStyleBackColor = true;
            this.btnListeyiTemizle.Click += new System.EventHandler(this.btnListeyiTemizle_Click);
            // 
            // btnListeOluştur
            // 
            this.btnListeOluştur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListeOluştur.Location = new System.Drawing.Point(3, 16);
            this.btnListeOluştur.Name = "btnListeOluştur";
            this.btnListeOluştur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnListeOluştur.Size = new System.Drawing.Size(485, 47);
            this.btnListeOluştur.TabIndex = 0;
            this.btnListeOluştur.Text = "Oynatma Listesi Oluştur";
            this.btnListeOluştur.UseVisualStyleBackColor = true;
            this.btnListeOluştur.Click += new System.EventHandler(this.btnListeOluştur_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblŞarkıİsmi);
            this.groupBox3.Controls.Add(this.btnİleriSar);
            this.groupBox3.Controls.Add(this.btnGeriSar);
            this.groupBox3.Controls.Add(this.btnÖncekiŞarkı);
            this.groupBox3.Controls.Add(this.btnSonrakiŞarkı);
            this.groupBox3.Controls.Add(this.btnDevamEt);
            this.groupBox3.Controls.Add(this.btnDurdur);
            this.groupBox3.Controls.Add(this.btnDuraklat);
            this.groupBox3.Controls.Add(this.btnOynat);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 390);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(691, 73);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Oynatma ";
            // 
            // btnİleriSar
            // 
            this.btnİleriSar.Location = new System.Drawing.Point(610, 19);
            this.btnİleriSar.Name = "btnİleriSar";
            this.btnİleriSar.Size = new System.Drawing.Size(75, 23);
            this.btnİleriSar.TabIndex = 7;
            this.btnİleriSar.Text = ">>>";
            this.btnİleriSar.UseVisualStyleBackColor = true;
            this.btnİleriSar.Click += new System.EventHandler(this.btnİleriSar_Click);
            // 
            // btnGeriSar
            // 
            this.btnGeriSar.Location = new System.Drawing.Point(529, 19);
            this.btnGeriSar.Name = "btnGeriSar";
            this.btnGeriSar.Size = new System.Drawing.Size(75, 23);
            this.btnGeriSar.TabIndex = 6;
            this.btnGeriSar.Text = "<<<";
            this.btnGeriSar.UseVisualStyleBackColor = true;
            this.btnGeriSar.Click += new System.EventHandler(this.btnGeriSar_Click);
            // 
            // btnÖncekiŞarkı
            // 
            this.btnÖncekiŞarkı.Location = new System.Drawing.Point(432, 19);
            this.btnÖncekiŞarkı.Name = "btnÖncekiŞarkı";
            this.btnÖncekiŞarkı.Size = new System.Drawing.Size(91, 23);
            this.btnÖncekiŞarkı.TabIndex = 5;
            this.btnÖncekiŞarkı.Text = "Önceki Şarkı";
            this.btnÖncekiŞarkı.UseVisualStyleBackColor = true;
            this.btnÖncekiŞarkı.Click += new System.EventHandler(this.btnÖncekiŞarkı_Click);
            // 
            // btnSonrakiŞarkı
            // 
            this.btnSonrakiŞarkı.Location = new System.Drawing.Point(336, 19);
            this.btnSonrakiŞarkı.Name = "btnSonrakiŞarkı";
            this.btnSonrakiŞarkı.Size = new System.Drawing.Size(90, 23);
            this.btnSonrakiŞarkı.TabIndex = 4;
            this.btnSonrakiŞarkı.Text = "Sonraki Şarkı";
            this.btnSonrakiŞarkı.UseVisualStyleBackColor = true;
            this.btnSonrakiŞarkı.Click += new System.EventHandler(this.btnSonrakiŞarkı_Click);
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.Location = new System.Drawing.Point(255, 19);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(75, 23);
            this.btnDevamEt.TabIndex = 3;
            this.btnDevamEt.Text = "Devam Ettir";
            this.btnDevamEt.UseVisualStyleBackColor = true;
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(174, 19);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(75, 23);
            this.btnDurdur.TabIndex = 2;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnDuraklat
            // 
            this.btnDuraklat.Location = new System.Drawing.Point(93, 19);
            this.btnDuraklat.Name = "btnDuraklat";
            this.btnDuraklat.Size = new System.Drawing.Size(75, 23);
            this.btnDuraklat.TabIndex = 1;
            this.btnDuraklat.Text = "Duraklat";
            this.btnDuraklat.UseVisualStyleBackColor = true;
            this.btnDuraklat.Click += new System.EventHandler(this.btnDuraklat_Click);
            // 
            // btnOynat
            // 
            this.btnOynat.Location = new System.Drawing.Point(12, 19);
            this.btnOynat.Name = "btnOynat";
            this.btnOynat.Size = new System.Drawing.Size(75, 23);
            this.btnOynat.TabIndex = 0;
            this.btnOynat.Text = "Oynat";
            this.btnOynat.UseVisualStyleBackColor = true;
            this.btnOynat.Click += new System.EventHandler(this.btnOynat_Click);
            // 
            // lblŞarkıİsmi
            // 
            this.lblŞarkıİsmi.AutoSize = true;
            this.lblŞarkıİsmi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblŞarkıİsmi.ForeColor = System.Drawing.Color.Blue;
            this.lblŞarkıİsmi.Location = new System.Drawing.Point(3, 57);
            this.lblŞarkıİsmi.Name = "lblŞarkıİsmi";
            this.lblŞarkıİsmi.Size = new System.Drawing.Size(0, 13);
            this.lblŞarkıİsmi.TabIndex = 8;
            // 
            // MüzikÇalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(936, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wdpMüzik);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lstMüzik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MüzikÇalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müzik Çalar";
            this.Load += new System.EventHandler(this.MüzikÇalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wdpMüzik)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wdpMüzik;
        private System.Windows.Forms.ListBox lstMüzik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSesAzalt;
        private System.Windows.Forms.Button btnSesArttır;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnŞarkıyıTemizle;
        private System.Windows.Forms.Button btnListeyiTemizle;
        private System.Windows.Forms.Button btnListeOluştur;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnİleriSar;
        private System.Windows.Forms.Button btnGeriSar;
        private System.Windows.Forms.Button btnÖncekiŞarkı;
        private System.Windows.Forms.Button btnSonrakiŞarkı;
        private System.Windows.Forms.Button btnDevamEt;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnDuraklat;
        private System.Windows.Forms.Button btnOynat;
        private System.Windows.Forms.Label lblŞarkıİsmi;
    }
}
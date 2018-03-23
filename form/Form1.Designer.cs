namespace form
{
    partial class Form1
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
            this.gbKitapEkleme = new System.Windows.Forms.GroupBox();
            this.lbBarkod = new System.Windows.Forms.Label();
            this.tbBarkod = new System.Windows.Forms.TextBox();
            this.lbYazarAdi = new System.Windows.Forms.Label();
            this.lbKitapAdi = new System.Windows.Forms.Label();
            this.tbYazarAdi = new System.Windows.Forms.TextBox();
            this.tbKitapAdi = new System.Windows.Forms.TextBox();
            this.bKitap = new System.Windows.Forms.Button();
            this.gbUyeEkleme = new System.Windows.Forms.GroupBox();
            this.lbUyeSoyadi = new System.Windows.Forms.Label();
            this.tbUyeSoyadi = new System.Windows.Forms.TextBox();
            this.lbUyeAdi = new System.Windows.Forms.Label();
            this.lbUyeNo = new System.Windows.Forms.Label();
            this.tbUyeAdi = new System.Windows.Forms.TextBox();
            this.tbUyeNo = new System.Windows.Forms.TextBox();
            this.bUye = new System.Windows.Forms.Button();
            this.gbIslem = new System.Windows.Forms.GroupBox();
            this.bUyeSil = new System.Windows.Forms.Button();
            this.bKitapSil = new System.Windows.Forms.Button();
            this.lvUye = new System.Windows.Forms.ListView();
            this.chUyeNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUyeAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUyeSoyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvKitap = new System.Windows.Forms.ListView();
            this.chBarkod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKitapAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chYazarAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTeslimDurumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbUyeSecimi = new System.Windows.Forms.Label();
            this.lbKitapSecimi = new System.Windows.Forms.Label();
            this.bEmanet = new System.Windows.Forms.Button();
            this.gbUyelerdekiler = new System.Windows.Forms.GroupBox();
            this.bTeslim = new System.Windows.Forms.Button();
            this.lvTeslim = new System.Windows.Forms.ListView();
            this.chKitap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bKitapAra = new System.Windows.Forms.Button();
            this.bUyeAra = new System.Windows.Forms.Button();
            this.bGeriAl = new System.Windows.Forms.Button();
            this.lvYedekKitap = new System.Windows.Forms.ListView();
            this.lvYedekUye = new System.Windows.Forms.ListView();
            this.bGeriAlUye = new System.Windows.Forms.Button();
            this.gbKitapEkleme.SuspendLayout();
            this.gbUyeEkleme.SuspendLayout();
            this.gbIslem.SuspendLayout();
            this.gbUyelerdekiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKitapEkleme
            // 
            this.gbKitapEkleme.Controls.Add(this.bKitapAra);
            this.gbKitapEkleme.Controls.Add(this.lbBarkod);
            this.gbKitapEkleme.Controls.Add(this.tbBarkod);
            this.gbKitapEkleme.Controls.Add(this.lbYazarAdi);
            this.gbKitapEkleme.Controls.Add(this.lbKitapAdi);
            this.gbKitapEkleme.Controls.Add(this.tbYazarAdi);
            this.gbKitapEkleme.Controls.Add(this.tbKitapAdi);
            this.gbKitapEkleme.Controls.Add(this.bKitap);
            this.gbKitapEkleme.Location = new System.Drawing.Point(15, 3);
            this.gbKitapEkleme.Name = "gbKitapEkleme";
            this.gbKitapEkleme.Size = new System.Drawing.Size(273, 158);
            this.gbKitapEkleme.TabIndex = 0;
            this.gbKitapEkleme.TabStop = false;
            this.gbKitapEkleme.Text = "Kitap İşlemleri";
            // 
            // lbBarkod
            // 
            this.lbBarkod.AutoSize = true;
            this.lbBarkod.Location = new System.Drawing.Point(18, 32);
            this.lbBarkod.Name = "lbBarkod";
            this.lbBarkod.Size = new System.Drawing.Size(35, 13);
            this.lbBarkod.TabIndex = 6;
            this.lbBarkod.Text = "ISBN:";
            // 
            // tbBarkod
            // 
            this.tbBarkod.Location = new System.Drawing.Point(85, 29);
            this.tbBarkod.MaxLength = 13;
            this.tbBarkod.Name = "tbBarkod";
            this.tbBarkod.Size = new System.Drawing.Size(160, 20);
            this.tbBarkod.TabIndex = 5;
            this.tbBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBarkod_KeyPress);
            // 
            // lbYazarAdi
            // 
            this.lbYazarAdi.AutoSize = true;
            this.lbYazarAdi.Location = new System.Drawing.Point(19, 84);
            this.lbYazarAdi.Name = "lbYazarAdi";
            this.lbYazarAdi.Size = new System.Drawing.Size(55, 13);
            this.lbYazarAdi.TabIndex = 4;
            this.lbYazarAdi.Text = "Yazar Adı:";
            // 
            // lbKitapAdi
            // 
            this.lbKitapAdi.AutoSize = true;
            this.lbKitapAdi.Location = new System.Drawing.Point(19, 58);
            this.lbKitapAdi.Name = "lbKitapAdi";
            this.lbKitapAdi.Size = new System.Drawing.Size(52, 13);
            this.lbKitapAdi.TabIndex = 3;
            this.lbKitapAdi.Text = "Kitap Adı:";
            // 
            // tbYazarAdi
            // 
            this.tbYazarAdi.Location = new System.Drawing.Point(85, 80);
            this.tbYazarAdi.Name = "tbYazarAdi";
            this.tbYazarAdi.Size = new System.Drawing.Size(160, 20);
            this.tbYazarAdi.TabIndex = 2;
            // 
            // tbKitapAdi
            // 
            this.tbKitapAdi.Location = new System.Drawing.Point(85, 55);
            this.tbKitapAdi.Name = "tbKitapAdi";
            this.tbKitapAdi.Size = new System.Drawing.Size(160, 20);
            this.tbKitapAdi.TabIndex = 1;
            // 
            // bKitap
            // 
            this.bKitap.Location = new System.Drawing.Point(150, 119);
            this.bKitap.Name = "bKitap";
            this.bKitap.Size = new System.Drawing.Size(83, 24);
            this.bKitap.TabIndex = 0;
            this.bKitap.Text = "Yeni Kitap";
            this.bKitap.UseVisualStyleBackColor = true;
            this.bKitap.Click += new System.EventHandler(this.bKitap_Click);
            // 
            // gbUyeEkleme
            // 
            this.gbUyeEkleme.Controls.Add(this.bUyeAra);
            this.gbUyeEkleme.Controls.Add(this.lbUyeSoyadi);
            this.gbUyeEkleme.Controls.Add(this.tbUyeSoyadi);
            this.gbUyeEkleme.Controls.Add(this.lbUyeAdi);
            this.gbUyeEkleme.Controls.Add(this.lbUyeNo);
            this.gbUyeEkleme.Controls.Add(this.tbUyeAdi);
            this.gbUyeEkleme.Controls.Add(this.tbUyeNo);
            this.gbUyeEkleme.Controls.Add(this.bUye);
            this.gbUyeEkleme.Location = new System.Drawing.Point(294, 3);
            this.gbUyeEkleme.Name = "gbUyeEkleme";
            this.gbUyeEkleme.Size = new System.Drawing.Size(288, 158);
            this.gbUyeEkleme.TabIndex = 1;
            this.gbUyeEkleme.TabStop = false;
            this.gbUyeEkleme.Text = "Üye İşlemleri";
            // 
            // lbUyeSoyadi
            // 
            this.lbUyeSoyadi.AutoSize = true;
            this.lbUyeSoyadi.Location = new System.Drawing.Point(34, 87);
            this.lbUyeSoyadi.Name = "lbUyeSoyadi";
            this.lbUyeSoyadi.Size = new System.Drawing.Size(42, 13);
            this.lbUyeSoyadi.TabIndex = 7;
            this.lbUyeSoyadi.Text = "Soyadı:";
            // 
            // tbUyeSoyadi
            // 
            this.tbUyeSoyadi.Location = new System.Drawing.Point(101, 84);
            this.tbUyeSoyadi.Name = "tbUyeSoyadi";
            this.tbUyeSoyadi.Size = new System.Drawing.Size(157, 20);
            this.tbUyeSoyadi.TabIndex = 6;
            // 
            // lbUyeAdi
            // 
            this.lbUyeAdi.AutoSize = true;
            this.lbUyeAdi.Location = new System.Drawing.Point(34, 62);
            this.lbUyeAdi.Name = "lbUyeAdi";
            this.lbUyeAdi.Size = new System.Drawing.Size(25, 13);
            this.lbUyeAdi.TabIndex = 5;
            this.lbUyeAdi.Text = "Adı:";
            // 
            // lbUyeNo
            // 
            this.lbUyeNo.AutoSize = true;
            this.lbUyeNo.Location = new System.Drawing.Point(34, 36);
            this.lbUyeNo.Name = "lbUyeNo";
            this.lbUyeNo.Size = new System.Drawing.Size(46, 13);
            this.lbUyeNo.TabIndex = 4;
            this.lbUyeNo.Text = "Üye No:";
            // 
            // tbUyeAdi
            // 
            this.tbUyeAdi.Location = new System.Drawing.Point(101, 58);
            this.tbUyeAdi.Name = "tbUyeAdi";
            this.tbUyeAdi.Size = new System.Drawing.Size(157, 20);
            this.tbUyeAdi.TabIndex = 3;
            // 
            // tbUyeNo
            // 
            this.tbUyeNo.Location = new System.Drawing.Point(101, 32);
            this.tbUyeNo.MaxLength = 6;
            this.tbUyeNo.Name = "tbUyeNo";
            this.tbUyeNo.Size = new System.Drawing.Size(157, 20);
            this.tbUyeNo.TabIndex = 2;
            this.tbUyeNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUyeNo_KeyPress);
            // 
            // bUye
            // 
            this.bUye.Location = new System.Drawing.Point(157, 119);
            this.bUye.Name = "bUye";
            this.bUye.Size = new System.Drawing.Size(82, 24);
            this.bUye.TabIndex = 1;
            this.bUye.Text = "Yeni Üye";
            this.bUye.UseVisualStyleBackColor = true;
            this.bUye.Click += new System.EventHandler(this.bUye_Click);
            // 
            // gbIslem
            // 
            this.gbIslem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbIslem.Controls.Add(this.bGeriAlUye);
            this.gbIslem.Controls.Add(this.bGeriAl);
            this.gbIslem.Controls.Add(this.bUyeSil);
            this.gbIslem.Controls.Add(this.bKitapSil);
            this.gbIslem.Controls.Add(this.lvUye);
            this.gbIslem.Controls.Add(this.lvKitap);
            this.gbIslem.Controls.Add(this.lbUyeSecimi);
            this.gbIslem.Controls.Add(this.lbKitapSecimi);
            this.gbIslem.Location = new System.Drawing.Point(15, 165);
            this.gbIslem.Name = "gbIslem";
            this.gbIslem.Size = new System.Drawing.Size(567, 259);
            this.gbIslem.TabIndex = 2;
            this.gbIslem.TabStop = false;
            this.gbIslem.Text = "Kitap ve Üye Listesi";
            // 
            // bUyeSil
            // 
            this.bUyeSil.Location = new System.Drawing.Point(472, 230);
            this.bUyeSil.Name = "bUyeSil";
            this.bUyeSil.Size = new System.Drawing.Size(75, 23);
            this.bUyeSil.TabIndex = 8;
            this.bUyeSil.Text = "Üye Sil";
            this.bUyeSil.UseVisualStyleBackColor = true;
            this.bUyeSil.Click += new System.EventHandler(this.bUyeSil_Click);
            // 
            // bKitapSil
            // 
            this.bKitapSil.Location = new System.Drawing.Point(254, 230);
            this.bKitapSil.Name = "bKitapSil";
            this.bKitapSil.Size = new System.Drawing.Size(75, 23);
            this.bKitapSil.TabIndex = 7;
            this.bKitapSil.Text = "Kitap Sil";
            this.bKitapSil.UseVisualStyleBackColor = true;
            this.bKitapSil.Click += new System.EventHandler(this.bKitapSil_Click);
            // 
            // lvUye
            // 
            this.lvUye.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUyeNo,
            this.chUyeAdi,
            this.chUyeSoyadi});
            this.lvUye.HideSelection = false;
            this.lvUye.Location = new System.Drawing.Point(353, 32);
            this.lvUye.Name = "lvUye";
            this.lvUye.Size = new System.Drawing.Size(208, 195);
            this.lvUye.TabIndex = 6;
            this.lvUye.UseCompatibleStateImageBehavior = false;
            // 
            // chUyeNo
            // 
            this.chUyeNo.Text = "Üye No";
            this.chUyeNo.Width = 58;
            // 
            // chUyeAdi
            // 
            this.chUyeAdi.Text = "Adı";
            this.chUyeAdi.Width = 75;
            // 
            // chUyeSoyadi
            // 
            this.chUyeSoyadi.Text = "Soyadı";
            this.chUyeSoyadi.Width = 70;
            // 
            // lvKitap
            // 
            this.lvKitap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBarkod,
            this.chKitapAdi,
            this.chYazarAdi,
            this.chTeslimDurumu});
            this.lvKitap.HideSelection = false;
            this.lvKitap.Location = new System.Drawing.Point(15, 32);
            this.lvKitap.Name = "lvKitap";
            this.lvKitap.Size = new System.Drawing.Size(332, 195);
            this.lvKitap.TabIndex = 5;
            this.lvKitap.UseCompatibleStateImageBehavior = false;
            this.lvKitap.SelectedIndexChanged += new System.EventHandler(this.lvKitap_SelectedIndexChanged);
            // 
            // chBarkod
            // 
            this.chBarkod.Text = "ISBN";
            this.chBarkod.Width = 65;
            // 
            // chKitapAdi
            // 
            this.chKitapAdi.Text = "Kitap Adı";
            this.chKitapAdi.Width = 95;
            // 
            // chYazarAdi
            // 
            this.chYazarAdi.Text = "Yazar Adı";
            this.chYazarAdi.Width = 85;
            // 
            // chTeslimDurumu
            // 
            this.chTeslimDurumu.Text = "Teslim Durumu";
            this.chTeslimDurumu.Width = 80;
            // 
            // lbUyeSecimi
            // 
            this.lbUyeSecimi.AutoSize = true;
            this.lbUyeSecimi.Location = new System.Drawing.Point(362, 16);
            this.lbUyeSecimi.Name = "lbUyeSecimi";
            this.lbUyeSecimi.Size = new System.Drawing.Size(63, 13);
            this.lbUyeSecimi.TabIndex = 3;
            this.lbUyeSecimi.Text = "Üye Seçimi:";
            this.lbUyeSecimi.Click += new System.EventHandler(this.lbUyeSecimi_Click);
            // 
            // lbKitapSecimi
            // 
            this.lbKitapSecimi.AutoSize = true;
            this.lbKitapSecimi.Location = new System.Drawing.Point(19, 16);
            this.lbKitapSecimi.Name = "lbKitapSecimi";
            this.lbKitapSecimi.Size = new System.Drawing.Size(68, 13);
            this.lbKitapSecimi.TabIndex = 2;
            this.lbKitapSecimi.Text = "Kitap Seçimi:";
            // 
            // bEmanet
            // 
            this.bEmanet.Location = new System.Drawing.Point(175, 392);
            this.bEmanet.Name = "bEmanet";
            this.bEmanet.Size = new System.Drawing.Size(75, 23);
            this.bEmanet.TabIndex = 4;
            this.bEmanet.Text = "Emanet Et";
            this.bEmanet.UseVisualStyleBackColor = true;
            this.bEmanet.Click += new System.EventHandler(this.bEmanet_Click);
            // 
            // gbUyelerdekiler
            // 
            this.gbUyelerdekiler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUyelerdekiler.AutoSize = true;
            this.gbUyelerdekiler.Controls.Add(this.lvYedekUye);
            this.gbUyelerdekiler.Controls.Add(this.lvYedekKitap);
            this.gbUyelerdekiler.Controls.Add(this.bTeslim);
            this.gbUyelerdekiler.Controls.Add(this.lvTeslim);
            this.gbUyelerdekiler.Controls.Add(this.bEmanet);
            this.gbUyelerdekiler.Location = new System.Drawing.Point(588, 3);
            this.gbUyelerdekiler.Name = "gbUyelerdekiler";
            this.gbUyelerdekiler.Size = new System.Drawing.Size(353, 437);
            this.gbUyelerdekiler.TabIndex = 3;
            this.gbUyelerdekiler.TabStop = false;
            this.gbUyelerdekiler.Text = "Emanet Edilmiş Kitaplar";
            // 
            // bTeslim
            // 
            this.bTeslim.Location = new System.Drawing.Point(256, 392);
            this.bTeslim.Name = "bTeslim";
            this.bTeslim.Size = new System.Drawing.Size(75, 23);
            this.bTeslim.TabIndex = 1;
            this.bTeslim.Text = "Teslim Al";
            this.bTeslim.UseVisualStyleBackColor = true;
            this.bTeslim.Click += new System.EventHandler(this.bTeslim_Click);
            // 
            // lvTeslim
            // 
            this.lvTeslim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chKitap,
            this.chUye,
            this.chTarih});
            this.lvTeslim.HideSelection = false;
            this.lvTeslim.Location = new System.Drawing.Point(8, 18);
            this.lvTeslim.Name = "lvTeslim";
            this.lvTeslim.Size = new System.Drawing.Size(336, 368);
            this.lvTeslim.TabIndex = 0;
            this.lvTeslim.UseCompatibleStateImageBehavior = false;
            this.lvTeslim.SelectedIndexChanged += new System.EventHandler(this.lvTeslim_SelectedIndexChanged);
            // 
            // chKitap
            // 
            this.chKitap.Text = "Kitap Adı";
            this.chKitap.Width = 120;
            // 
            // chUye
            // 
            this.chUye.Text = "Üye Adı";
            this.chUye.Width = 120;
            // 
            // chTarih
            // 
            this.chTarih.Text = "Teslim Tarihi";
            this.chTarih.Width = 90;
            // 
            // bKitapAra
            // 
            this.bKitapAra.Location = new System.Drawing.Point(45, 119);
            this.bKitapAra.Name = "bKitapAra";
            this.bKitapAra.Size = new System.Drawing.Size(80, 24);
            this.bKitapAra.TabIndex = 7;
            this.bKitapAra.Text = "Kitap Ara";
            this.bKitapAra.UseVisualStyleBackColor = true;
            this.bKitapAra.Click += new System.EventHandler(this.bKitapAra_Click);
            // 
            // bUyeAra
            // 
            this.bUyeAra.Location = new System.Drawing.Point(49, 119);
            this.bUyeAra.Name = "bUyeAra";
            this.bUyeAra.Size = new System.Drawing.Size(80, 24);
            this.bUyeAra.TabIndex = 8;
            this.bUyeAra.Text = "Üye Ara";
            this.bUyeAra.UseVisualStyleBackColor = true;
            this.bUyeAra.Click += new System.EventHandler(this.bUyeAra_Click);
            // 
            // bGeriAl
            // 
            this.bGeriAl.Location = new System.Drawing.Point(22, 230);
            this.bGeriAl.Name = "bGeriAl";
            this.bGeriAl.Size = new System.Drawing.Size(75, 23);
            this.bGeriAl.TabIndex = 9;
            this.bGeriAl.Text = "Geri Al";
            this.bGeriAl.UseVisualStyleBackColor = true;
            this.bGeriAl.Visible = false;
            this.bGeriAl.Click += new System.EventHandler(this.bGeriAl_Click);
            // 
            // lvYedekKitap
            // 
            this.lvYedekKitap.Location = new System.Drawing.Point(40, 392);
            this.lvYedekKitap.Name = "lvYedekKitap";
            this.lvYedekKitap.Size = new System.Drawing.Size(66, 10);
            this.lvYedekKitap.TabIndex = 5;
            this.lvYedekKitap.UseCompatibleStateImageBehavior = false;
            this.lvYedekKitap.Visible = false;
            // 
            // lvYedekUye
            // 
            this.lvYedekUye.Location = new System.Drawing.Point(40, 408);
            this.lvYedekUye.Name = "lvYedekUye";
            this.lvYedekUye.Size = new System.Drawing.Size(65, 10);
            this.lvYedekUye.TabIndex = 6;
            this.lvYedekUye.UseCompatibleStateImageBehavior = false;
            this.lvYedekUye.Visible = false;
            // 
            // bGeriAlUye
            // 
            this.bGeriAlUye.Location = new System.Drawing.Point(365, 230);
            this.bGeriAlUye.Name = "bGeriAlUye";
            this.bGeriAlUye.Size = new System.Drawing.Size(75, 23);
            this.bGeriAlUye.TabIndex = 10;
            this.bGeriAlUye.Text = "Geri Al";
            this.bGeriAlUye.UseVisualStyleBackColor = true;
            this.bGeriAlUye.Visible = false;
            this.bGeriAlUye.Click += new System.EventHandler(this.bGeriAlUye_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 430);
            this.Controls.Add(this.gbUyelerdekiler);
            this.Controls.Add(this.gbIslem);
            this.Controls.Add(this.gbUyeEkleme);
            this.Controls.Add(this.gbKitapEkleme);
            this.Name = "Form1";
            this.Text = "Kütüphane Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbKitapEkleme.ResumeLayout(false);
            this.gbKitapEkleme.PerformLayout();
            this.gbUyeEkleme.ResumeLayout(false);
            this.gbUyeEkleme.PerformLayout();
            this.gbIslem.ResumeLayout(false);
            this.gbIslem.PerformLayout();
            this.gbUyelerdekiler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKitapEkleme;
        private System.Windows.Forms.Label lbYazarAdi;
        private System.Windows.Forms.Label lbKitapAdi;
        private System.Windows.Forms.TextBox tbYazarAdi;
        private System.Windows.Forms.TextBox tbKitapAdi;
        private System.Windows.Forms.Button bKitap;
        private System.Windows.Forms.GroupBox gbUyeEkleme;
        private System.Windows.Forms.Label lbUyeAdi;
        private System.Windows.Forms.Label lbUyeNo;
        private System.Windows.Forms.TextBox tbUyeAdi;
        private System.Windows.Forms.TextBox tbUyeNo;
        private System.Windows.Forms.Button bUye;
        private System.Windows.Forms.GroupBox gbIslem;
        private System.Windows.Forms.Button bEmanet;
        private System.Windows.Forms.Label lbUyeSecimi;
        private System.Windows.Forms.Label lbKitapSecimi;
        private System.Windows.Forms.GroupBox gbUyelerdekiler;
        private System.Windows.Forms.ListView lvTeslim;
        private System.Windows.Forms.ColumnHeader chUye;
        private System.Windows.Forms.ColumnHeader chKitap;
        private System.Windows.Forms.ListView lvUye;
        private System.Windows.Forms.ColumnHeader chUyeNo;
        private System.Windows.Forms.ColumnHeader chUyeAdi;
        private System.Windows.Forms.ListView lvKitap;
        private System.Windows.Forms.ColumnHeader chKitapAdi;
        private System.Windows.Forms.ColumnHeader chYazarAdi;
        private System.Windows.Forms.ColumnHeader chUyeSoyadi;
        private System.Windows.Forms.Label lbBarkod;
        private System.Windows.Forms.TextBox tbBarkod;
        private System.Windows.Forms.Label lbUyeSoyadi;
        private System.Windows.Forms.TextBox tbUyeSoyadi;
        private System.Windows.Forms.ColumnHeader chBarkod;
        private System.Windows.Forms.ColumnHeader chTeslimDurumu;
        private System.Windows.Forms.Button bTeslim;
        private System.Windows.Forms.Button bUyeSil;
        private System.Windows.Forms.Button bKitapSil;
        private System.Windows.Forms.ColumnHeader chTarih;
        private System.Windows.Forms.Button bKitapAra;
        private System.Windows.Forms.Button bUyeAra;
        private System.Windows.Forms.Button bGeriAl;
        private System.Windows.Forms.ListView lvYedekKitap;
        private System.Windows.Forms.Button bGeriAlUye;
        private System.Windows.Forms.ListView lvYedekUye;
    }
}


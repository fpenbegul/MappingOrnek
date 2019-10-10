namespace MappingOrnek4.UI
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
            this.grpPersonelKayit = new System.Windows.Forms.GroupBox();
            this.rdKadin = new System.Windows.Forms.RadioButton();
            this.rdErkek = new System.Windows.Forms.RadioButton();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBirimler = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnİletisim = new System.Windows.Forms.Button();
            this.grpPersonelKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersonelKayit
            // 
            this.grpPersonelKayit.Controls.Add(this.rdKadin);
            this.grpPersonelKayit.Controls.Add(this.rdErkek);
            this.grpPersonelKayit.Controls.Add(this.dtDogumTarihi);
            this.grpPersonelKayit.Controls.Add(this.txtTCNo);
            this.grpPersonelKayit.Controls.Add(this.txtSoyad);
            this.grpPersonelKayit.Controls.Add(this.txtAd);
            this.grpPersonelKayit.Controls.Add(this.label6);
            this.grpPersonelKayit.Controls.Add(this.label5);
            this.grpPersonelKayit.Controls.Add(this.label4);
            this.grpPersonelKayit.Controls.Add(this.label3);
            this.grpPersonelKayit.Controls.Add(this.label2);
            this.grpPersonelKayit.Controls.Add(this.label1);
            this.grpPersonelKayit.Controls.Add(this.cmbBirimler);
            this.grpPersonelKayit.Location = new System.Drawing.Point(3, 3);
            this.grpPersonelKayit.Name = "grpPersonelKayit";
            this.grpPersonelKayit.Size = new System.Drawing.Size(330, 220);
            this.grpPersonelKayit.TabIndex = 0;
            this.grpPersonelKayit.TabStop = false;
            // 
            // rdKadin
            // 
            this.rdKadin.AutoSize = true;
            this.rdKadin.Location = new System.Drawing.Point(155, 130);
            this.rdKadin.Name = "rdKadin";
            this.rdKadin.Size = new System.Drawing.Size(52, 17);
            this.rdKadin.TabIndex = 4;
            this.rdKadin.TabStop = true;
            this.rdKadin.Text = "Kadın";
            this.rdKadin.UseVisualStyleBackColor = true;
            // 
            // rdErkek
            // 
            this.rdErkek.AutoSize = true;
            this.rdErkek.Location = new System.Drawing.Point(96, 130);
            this.rdErkek.Name = "rdErkek";
            this.rdErkek.Size = new System.Drawing.Size(53, 17);
            this.rdErkek.TabIndex = 4;
            this.rdErkek.TabStop = true;
            this.rdErkek.Text = "Erkek";
            this.rdErkek.UseVisualStyleBackColor = true;
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Location = new System.Drawing.Point(96, 105);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtDogumTarihi.TabIndex = 3;
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(96, 79);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(226, 20);
            this.txtTCNo.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(96, 53);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(226, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(96, 20);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(226, 20);
            this.txtAd.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Birimi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cinsiyeti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "TcNo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // cmbBirimler
            // 
            this.cmbBirimler.FormattingEnabled = true;
            this.cmbBirimler.Items.AddRange(new object[] {
            "Yazılım",
            "Muhasebe",
            "İnsan Kaynakları",
            "Sosyal Medya Uzmanı",
            "Teknik Destek ",
            "Grafik Tasarım",
            "3D Çizim"});
            this.cmbBirimler.Location = new System.Drawing.Point(96, 160);
            this.cmbBirimler.Name = "cmbBirimler";
            this.cmbBirimler.Size = new System.Drawing.Size(121, 21);
            this.cmbBirimler.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(4, 230);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(160, 44);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(170, 229);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(163, 44);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnİletisim
            // 
            this.btnİletisim.Location = new System.Drawing.Point(3, 280);
            this.btnİletisim.Name = "btnİletisim";
            this.btnİletisim.Size = new System.Drawing.Size(330, 44);
            this.btnİletisim.TabIndex = 1;
            this.btnİletisim.Text = "İletişim Bilgilerini Gir";
            this.btnİletisim.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 356);
            this.Controls.Add(this.btnİletisim);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpPersonelKayit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPersonelKayit.ResumeLayout(false);
            this.grpPersonelKayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonelKayit;
        private System.Windows.Forms.ComboBox cmbBirimler;
        private System.Windows.Forms.RadioButton rdKadin;
        private System.Windows.Forms.RadioButton rdErkek;
        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnİletisim;
    }
}


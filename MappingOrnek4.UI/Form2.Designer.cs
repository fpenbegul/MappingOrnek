namespace MappingOrnek4.UI
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPersoneller = new System.Windows.Forms.ComboBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.grpIletisim = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYeniPersonel = new System.Windows.Forms.Button();
            this.btnTumKayitlar = new System.Windows.Forms.Button();
            this.grpIletisim.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İletişim Bilgisini Gireceğiniz Personeli Seçiniz...";
            // 
            // cmbPersoneller
            // 
            this.cmbPersoneller.FormattingEnabled = true;
            this.cmbPersoneller.Location = new System.Drawing.Point(16, 39);
            this.cmbPersoneller.Name = "cmbPersoneller";
            this.cmbPersoneller.Size = new System.Drawing.Size(219, 21);
            this.cmbPersoneller.TabIndex = 1;
            this.cmbPersoneller.SelectedIndexChanged += new System.EventHandler(this.CmbPersoneller_SelectedIndexChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(16, 66);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(219, 33);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Veya Güncelleme Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // grpIletisim
            // 
            this.grpIletisim.Controls.Add(this.btnKaydet);
            this.grpIletisim.Controls.Add(this.txtTelefon);
            this.grpIletisim.Controls.Add(this.txtAdres);
            this.grpIletisim.Controls.Add(this.txtEmail);
            this.grpIletisim.Controls.Add(this.label4);
            this.grpIletisim.Controls.Add(this.label3);
            this.grpIletisim.Controls.Add(this.label2);
            this.grpIletisim.Location = new System.Drawing.Point(16, 116);
            this.grpIletisim.Name = "grpIletisim";
            this.grpIletisim.Size = new System.Drawing.Size(286, 232);
            this.grpIletisim.TabIndex = 3;
            this.grpIletisim.TabStop = false;
            this.grpIletisim.Text = "İletişim Bilgisi Giriş Ekranı";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(87, 191);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(168, 35);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(87, 64);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(168, 20);
            this.txtTelefon.TabIndex = 11;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(87, 102);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(168, 84);
            this.txtAdres.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(87, 30);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adresi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefonu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-Mail Adresi :";
            // 
            // btnYeniPersonel
            // 
            this.btnYeniPersonel.Location = new System.Drawing.Point(16, 354);
            this.btnYeniPersonel.Name = "btnYeniPersonel";
            this.btnYeniPersonel.Size = new System.Drawing.Size(131, 46);
            this.btnYeniPersonel.TabIndex = 4;
            this.btnYeniPersonel.Text = "Yeni Personel";
            this.btnYeniPersonel.UseVisualStyleBackColor = true;
            this.btnYeniPersonel.Click += new System.EventHandler(this.BtnYeniPersonel_Click);
            // 
            // btnTumKayitlar
            // 
            this.btnTumKayitlar.Location = new System.Drawing.Point(171, 354);
            this.btnTumKayitlar.Name = "btnTumKayitlar";
            this.btnTumKayitlar.Size = new System.Drawing.Size(131, 46);
            this.btnTumKayitlar.TabIndex = 4;
            this.btnTumKayitlar.Text = "Tüm Kayıtlar";
            this.btnTumKayitlar.UseVisualStyleBackColor = true;
            this.btnTumKayitlar.Click += new System.EventHandler(this.BtnTumKayitlar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 418);
            this.Controls.Add(this.btnTumKayitlar);
            this.Controls.Add(this.btnYeniPersonel);
            this.Controls.Add(this.grpIletisim);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.cmbPersoneller);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpIletisim.ResumeLayout(false);
            this.grpIletisim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPersoneller;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.GroupBox grpIletisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnYeniPersonel;
        private System.Windows.Forms.Button btnTumKayitlar;
    }
}
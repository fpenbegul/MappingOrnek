namespace MappingOrnek4.UI
{
    partial class Form3
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
            this.grpKayit = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblGoruntule = new System.Windows.Forms.Label();
            this.grpArama = new System.Windows.Forms.GroupBox();
            this.btnTemizleArama = new System.Windows.Forms.Button();
            this.lbxSonuclar = new System.Windows.Forms.ListBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbAramaSecenekleri = new System.Windows.Forms.ComboBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.grpKayit.SuspendLayout();
            this.grpArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKayit
            // 
            this.grpKayit.Controls.Add(this.btnTemizle);
            this.grpKayit.Controls.Add(this.lblGoruntule);
            this.grpKayit.Location = new System.Drawing.Point(13, 4);
            this.grpKayit.Name = "grpKayit";
            this.grpKayit.Size = new System.Drawing.Size(231, 258);
            this.grpKayit.TabIndex = 0;
            this.grpKayit.TabStop = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(16, 192);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(197, 41);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // lblGoruntule
            // 
            this.lblGoruntule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGoruntule.Location = new System.Drawing.Point(16, 16);
            this.lblGoruntule.Name = "lblGoruntule";
            this.lblGoruntule.Size = new System.Drawing.Size(197, 172);
            this.lblGoruntule.TabIndex = 0;
            // 
            // grpArama
            // 
            this.grpArama.Controls.Add(this.btnTemizleArama);
            this.grpArama.Controls.Add(this.lbxSonuclar);
            this.grpArama.Controls.Add(this.btnAra);
            this.grpArama.Controls.Add(this.cmbAramaSecenekleri);
            this.grpArama.Controls.Add(this.txtAra);
            this.grpArama.Location = new System.Drawing.Point(250, 4);
            this.grpArama.Name = "grpArama";
            this.grpArama.Size = new System.Drawing.Size(231, 318);
            this.grpArama.TabIndex = 0;
            this.grpArama.TabStop = false;
            // 
            // btnTemizleArama
            // 
            this.btnTemizleArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizleArama.Location = new System.Drawing.Point(7, 245);
            this.btnTemizleArama.Name = "btnTemizleArama";
            this.btnTemizleArama.Size = new System.Drawing.Size(218, 41);
            this.btnTemizleArama.TabIndex = 1;
            this.btnTemizleArama.Text = "TEMİZLE";
            this.btnTemizleArama.UseVisualStyleBackColor = true;
            this.btnTemizleArama.Click += new System.EventHandler(this.BtnTemizleArama_Click);
            // 
            // lbxSonuclar
            // 
            this.lbxSonuclar.FormattingEnabled = true;
            this.lbxSonuclar.Location = new System.Drawing.Point(7, 92);
            this.lbxSonuclar.Name = "lbxSonuclar";
            this.lbxSonuclar.Size = new System.Drawing.Size(218, 147);
            this.lbxSonuclar.TabIndex = 3;
            this.lbxSonuclar.SelectedIndexChanged += new System.EventHandler(this.LbxSonuclar_SelectedIndexChanged);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(7, 47);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(218, 38);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ARAMA YAP";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // cmbAramaSecenekleri
            // 
            this.cmbAramaSecenekleri.FormattingEnabled = true;
            this.cmbAramaSecenekleri.Items.AddRange(new object[] {
            "ile başlayanlar",
            "ile bitenler",
            "içerenler"});
            this.cmbAramaSecenekleri.Location = new System.Drawing.Point(114, 18);
            this.cmbAramaSecenekleri.Name = "cmbAramaSecenekleri";
            this.cmbAramaSecenekleri.Size = new System.Drawing.Size(111, 21);
            this.cmbAramaSecenekleri.TabIndex = 1;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(7, 20);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 20);
            this.txtAra.TabIndex = 0;
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaMenu.Location = new System.Drawing.Point(13, 268);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(231, 54);
            this.btnAnaMenu.TabIndex = 1;
            this.btnAnaMenu.Text = "ANA MENÜ";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.BtnAnaMenu_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 340);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.grpArama);
            this.Controls.Add(this.grpKayit);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.grpKayit.ResumeLayout(false);
            this.grpArama.ResumeLayout(false);
            this.grpArama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKayit;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblGoruntule;
        private System.Windows.Forms.GroupBox grpArama;
        private System.Windows.Forms.Button btnTemizleArama;
        private System.Windows.Forms.ListBox lbxSonuclar;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbAramaSecenekleri;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAnaMenu;
    }
}
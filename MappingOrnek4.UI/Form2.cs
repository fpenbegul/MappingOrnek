using MappingOrnek4.DAL;
using MappingOrnek4.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingOrnek4.UI
{
    public partial class Form2 : Form
    {
        Form1 mainForm;
        Context db;
        public Form2(Form1 form1, Context context)
        {
            mainForm = form1;
            db = context;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbPersoneller.DataSource = db.Personeller.ToList();
            cmbPersoneller.DisplayMember = "FullName";
            cmbPersoneller.ValueMember = "PersonelID";
            btnKaydet.Enabled = btnGiris.Enabled = false;
            cmbPersoneller.SelectedIndex = -1;

        }

        private void CmbPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPersoneller.SelectedIndex == -1) return;
            btnGiris.Enabled = true;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
        IletisimBilgisi iletisimBilgisi;
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            iletisimBilgisi = db.IletisimBilgileri.Where(x => x.PersonelID ==
            (int)cmbPersoneller.SelectedValue).FirstOrDefault();

            if (iletisimBilgisi != null)
            {
                txtEmail.Text = iletisimBilgisi.Email;
                txtTelefon.Text = iletisimBilgisi.Telefon;
                txtAdres.Text = iletisimBilgisi.Adres;
            }
            else
                MessageBox.Show("Bu personele ait iletişim bilgisi henüz girilmemiş. Aşağıdaki alanları doldurabilirisiniz.");


            btnKaydet.Enabled = true;
            cmbPersoneller.Enabled = false;
            btnGiris.Enabled = false;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (iletisimBilgisi == null)  // Sıfırdan kayıt işlemi
            {
                iletisimBilgisi = new IletisimBilgisi()
                {
                    Email = txtEmail.Text,
                    Adres = txtAdres.Text,
                    Telefon = txtTelefon.Text,
                    PersonelID = (int)cmbPersoneller.SelectedValue
                };
                db.IletisimBilgileri.Add(iletisimBilgisi);
            }
            else   // update işlemi
            {
                iletisimBilgisi.Email = txtEmail.Text;
                iletisimBilgisi.Telefon = txtTelefon.Text;
                iletisimBilgisi.Adres = txtAdres.Text;
            }
            db.SaveChanges();
            cmbPersoneller.Enabled = true;
            btnKaydet.Enabled = false;
            cmbPersoneller.SelectedIndex = -1;
            MessageBox.Show("Kayıt veya Güncelleme İşlemi Tamamlandı!");
            Metotlar.Temizle(grpIletisim);
        }

        private void BtnYeniPersonel_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void BtnTumKayitlar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this, mainForm, db);
            Hide();
            form3.Show();
        }
    }
}

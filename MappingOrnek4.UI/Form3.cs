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
    public partial class Form3 : Form
    {
        Form1 mainForm;
        Form2 secondForm;
        Context db;

        public Form3(Form2 form2, Form1 form1, Context context)
        {
            mainForm = form1;
            secondForm = form2;
            db = context;




            InitializeComponent();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            List<Personel> personeller = new List<Personel>();
            switch (cmbAramaSecenekleri.SelectedIndex)
            {
                default:
                    MessageBox.Show("Lütfen bir arama seçeneği seçiniz!");
                    break;
                case 0: // ile başlayan
                    personeller = db.Personeller.Where(x => x.Isim.StartsWith(txtAra.Text)
                    || x.Soyisim.StartsWith(txtAra.Text)).ToList();
                    break;
                case 1: // ile biten
                    personeller = db.Personeller.Where(x => x.Isim.EndsWith(txtAra.Text)
                    || x.Soyisim.EndsWith(txtAra.Text)).ToList();
                    break;
                case 2: // içeren...
                    personeller = db.Personeller.Where(x => x.Isim.Contains(txtAra.Text)
                    || x.Soyisim.Contains(txtAra.Text)).ToList();
                    break;

            }
            Doldur(personeller);
        }
        void Doldur(List<Personel> liste)
        {
            lbxSonuclar.SelectedIndexChanged -= new EventHandler(LbxSonuclar_SelectedIndexChanged);
            lbxSonuclar.DataSource = liste;
            lbxSonuclar.DisplayMember = "FullName";
            lbxSonuclar.ValueMember = "PersonelID";

            lbxSonuclar.SelectedIndex = -1;
            lbxSonuclar.SelectedIndexChanged += new EventHandler(LbxSonuclar_SelectedIndexChanged);
        }
        private void BtnTemizleArama_Click(object sender, EventArgs e)
        {
            Metotlar.Temizle(grpArama);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Metotlar.Temizle(grpKayit);
        }

        private void BtnAnaMenu_Click(object sender, EventArgs e)
        {
            Hide();
            mainForm.Show();
        }

        private void LbxSonuclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxSonuclar.SelectedValue == null) return;

            Personel personel = db.Personeller.Find((int)lbxSonuclar.SelectedValue);
            IletisimBilgisi iletisimBilgisi = personel.IletisimBilgisi;

            if (iletisimBilgisi == null)
                lblGoruntule.Text = personel.ToString();
            else
                lblGoruntule.Text = personel + "\n" + iletisimBilgisi;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            secondForm.Show();
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Context db;

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Context();

            btnTemizle.Enabled = false;
            btnİletisim.Enabled = db.Personeller.ToList().Count > 0 ? true : false;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Metotlar.BosAlanVarmi(grpPersonelKayit))
                MessageBox.Show("Lütfen Tüm alanları Doldurunuz!");
            else
            {
                Personel personel = db.Personeller.FirstOrDefault(x => x.TCNo == txtTCNo.Text);
                if (personel == null)
                {
                    personel = new Personel()
                    {
                        Isim = txtAd.Text,
                        Soyisim = txtSoyad.Text,
                        Birim = cmbBirimler.Text,
                        Cinsiyet = rdErkek.Checked,
                        DogumTarihi = dtDogumTarihi.Value,
                        TCNo = txtTCNo.Text
                    };
                    db.Personeller.Add(personel);


                    btnİletisim.Enabled = btnTemizle.Enabled = true;
                    if (db.SaveChanges() >= 0)
                    {
                        MessageBox.Show("Kaydınız Gerçekleşmiştir...");
                    }

                }
                else
                    MessageBox.Show("Bu TC No'ya ait kayıt daha önce girilmiştir. Lütfen başka bir tc no giriniz...");
            }

        }
    }
}

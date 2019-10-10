using MappingOrnek4.DAL;
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

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingOrnek4.DATA
{
    public class Personel
    {
        public int PersonelID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TCNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }
        public string Birim { get; set; }

        public string FullName
        {
            get
            {
                return Isim + " " + Soyisim;
            }
        }


        public virtual IletisimBilgisi IletisimBilgisi { get; set; }

        public override string ToString()
        {
            return $"İsim Soyisim: {FullName}\nTcNo: {TCNo}\nDoğum Tarihi: {DogumTarihi.ToLongDateString()}" +
                $"\nCinsiyet: " + (Cinsiyet ? "Erkek" : "Kadın") + $"\nBirim: {Birim}";
        }


    }
}

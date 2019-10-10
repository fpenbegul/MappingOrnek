using MappingOrnek4.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingOrnek4.DAL
{
    public class PersonelMapping : EntityTypeConfiguration<Personel>
    {
        public PersonelMapping()
        {
            ToTable("Personeller");

            Property(x => x.Isim).IsRequired().HasMaxLength(20);
            Property(x => x.Soyisim).IsRequired().HasMaxLength(30);
            Property(x => x.TCNo).IsRequired().HasMaxLength(11).HasColumnType("char");
            Property(x => x.DogumTarihi).IsOptional().HasColumnType("datetime2");
            Property(x => x.Birim).IsRequired().HasMaxLength(20);

            Ignore(x => x.FullName); // unmapping işlemi uygular

            HasKey(x => x.PersonelID);
            HasRequired(x => x.IletisimBilgisi).WithRequiredPrincipal(x => x.Personel);



        }



    }
}

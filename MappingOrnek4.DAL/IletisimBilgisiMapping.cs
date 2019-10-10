using MappingOrnek4.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingOrnek4.DAL
{
    public class IletisimBilgisiMapping : EntityTypeConfiguration<IletisimBilgisi>
    {
        public IletisimBilgisiMapping()
        {
            ToTable("IletişimBilgileri");

            Property(x => x.Email).HasColumnType("nchar").HasMaxLength(50);
            Property(x => x.Telefon).HasColumnType("nchar").HasMaxLength(50);
            Property(x => x.Adres).HasMaxLength(150);

            HasKey(x => x.PersonelID);



        }
    }
}

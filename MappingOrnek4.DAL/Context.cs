using MappingOrnek4.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingOrnek4.DAL
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.Connection.ConnectionString = ("server=.; database=PersonellerMapping4Db; uid=sa; pwd=123");
        }

        public DbSet<Personel> Personeller { get; set; }
        public DbSet<IletisimBilgisi> IletisimBilgileri { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonelMapping());
            modelBuilder.Configurations.Add(new IletisimBilgisiMapping());
            base.OnModelCreating(modelBuilder);


        }


    }
}

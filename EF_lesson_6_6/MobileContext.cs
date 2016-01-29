using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_6
{
    class MobileContext : DbContext
    {
        public MobileContext()
            : base("EF_lesson_6_6")
        { }
        public DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>().Map(m =>
            {
                m.Properties(d => new { d.Name, d.Id });
                m.ToTable("Mobiles");
            }).Map(m =>
            {
                m.Properties(d => new { d.Company, d.Price });
                m.ToTable("MobilesInfo");
            }); ;
            base.OnModelCreating(modelBuilder);
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NguyenHoangThai.Model
{
    public partial class DatabaseQLHS : DbContext
    {
        public DatabaseQLHS()
            : base("name=DatabaseQLHS")
        {
        }

        public virtual DbSet<Diem> Diem { get; set; }
        public virtual DbSet<HocSinh> HocSinh { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HocSinh>()
                .HasOptional(e => e.Diem)
                .WithRequired(e => e.HocSinh);
        }
    }
}

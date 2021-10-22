using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace csharp_winform.Model
{
    public partial class StudentDBContext : DbContext
    {
        public StudentDBContext()
            : base("name=StudentDBContext")
        {
        }

        public virtual DbSet<DANGNHAP> DANGNHAPs { get; set; }
        public virtual DbSet<DIEMSV> DIEMSVs { get; set; }
        public virtual DbSet<GIANGVIEN> GIANGVIENs { get; set; }
        public virtual DbSet<KHOA> KHOAs { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<MONHOC> MONHOCs { get; set; }
        public virtual DbSet<SINHVIEN> SINHVIENs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.TenDN)
                .IsUnicode(false);

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.Quyen)
                .IsUnicode(false);

            modelBuilder.Entity<DIEMSV>()
                .Property(e => e.MSSV)
                .IsUnicode(false);

            modelBuilder.Entity<DIEMSV>()
                .Property(e => e.MAMH)
                .IsFixedLength();

            modelBuilder.Entity<KHOA>()
                .Property(e => e.MAKHOA)
                .IsFixedLength();

            modelBuilder.Entity<KHOA>()
                .HasMany(e => e.LOPs)
                .WithRequired(e => e.KHOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOP>()
                .Property(e => e.MAKHOA)
                .IsFixedLength();

            modelBuilder.Entity<LOP>()
                .Property(e => e.MALOP)
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .HasMany(e => e.SINHVIENs)
                .WithRequired(e => e.LOP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONHOC>()
                .Property(e => e.MAMH)
                .IsFixedLength();

            modelBuilder.Entity<MONHOC>()
                .HasMany(e => e.DIEMSVs)
                .WithRequired(e => e.MONHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MSSV)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MALOP)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .HasMany(e => e.DIEMSVs)
                .WithRequired(e => e.SINHVIEN)
                .WillCascadeOnDelete(false);
        }
    }
}

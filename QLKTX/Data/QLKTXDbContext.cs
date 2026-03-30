using Microsoft.EntityFrameworkCore;
using System.Configuration;


namespace QLKTX.Data
{
    public class QLKTXDbContext : DbContext
    {
        public QLKTXDbContext() { }
        public QLKTXDbContext(DbContextOptions<QLKTXDbContext> options) : base(options)
        {
        }


        public DbSet<SinhVien> SinhVien { get; set; }
        public DbSet<Phong> Phong { get; set; }
        public DbSet<LoaiPhong> LoaiPhong { get; set; }
        public DbSet<ToaNha> ToaNha { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<DangKy> DangKy { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        public DbSet<DienNuoc> DienNuoc { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                
                string conn = @"Data Source=DESKTOP-8FQTHJ9\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True;TrustServerCertificate=True";

                optionsBuilder.UseSqlServer(conn);
            }
        
        }
    }
}
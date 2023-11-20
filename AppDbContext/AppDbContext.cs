using Microsoft.EntityFrameworkCore;
using Models;
namespace AppDbContext
{
    public class AppContext : DbContext
    {
        private string connectionString = @"Data Source=NIHONGGOO\SQLEXPRESS;Initial Catalog=QLTX;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public DbSet<TaiSan> TaiSan { get; set; }
        public DbSet<LoaiTaiSan> LoaiTaiSan { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        internal void waite()
        {
            throw new NotImplementedException();
        }
    }
}
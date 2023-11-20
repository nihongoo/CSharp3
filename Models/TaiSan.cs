using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class TaiSan
    {
#pragma warning disable CS8618
        [Key] public int MaTaiSan { get; set; }
        public string TenTaiSan { get; set; }
        public DateTime? NgayMua { get; set; }
        public double? GiaMua { get; set; }
        public short? MaLoaiTS { get; set; }
        public string? TinhTrang { get; set; }
        public string? TrangThaiSD { get; set; }
    }
}

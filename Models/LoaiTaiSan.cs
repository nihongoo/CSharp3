using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class LoaiTaiSan
    {
        [Key] public short? MaLoaiTS { get; set; }
        public string? TenLoaiTS { get; set; }
    }
}
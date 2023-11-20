using Models;
using Repositories;
namespace Services
{
    public class ServiceLoaiTaiSan
    {
        static ILoaiTaiSanRepository loaiTaiSanRepository;
        static ServiceLoaiTaiSan()
        {
            loaiTaiSanRepository = new LoaiTaiSanRepository();
        }
        /// <summary>
        /// Get all
        /// </summary>
        /// <returns></returns>
        public static List<LoaiTaiSan> GetAll()
        {
            return loaiTaiSanRepository.GetAll();
        }
    }
}
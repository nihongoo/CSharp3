using Models;
using Repositories;
namespace Services
{
    public class TaiSanService
    {
        static ILoaiTaiSan taiSanRepository;
        /// <summary>
        /// Static constructor
        /// </summary>
        static TaiSanService()
        {
            taiSanRepository = new TaiSanRepository();
        }
        /// <summary>
        /// Get all
        /// </summary>
        /// <returns></returns>
        public static List<TaiSan> GetAll()
        {
            return taiSanRepository.GetAll();
        }
        /// <summary>
        /// Find by Name
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<TaiSan> FindByName(string value)
        {
            return taiSanRepository.FindByName(value);
        }
        /// <summary>
        /// Filter by used state
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<TaiSan> FilterByUsedState(string value)
        {
            return taiSanRepository.FilterByUsedState(value);
        }
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static TaiSan Create(TaiSan obj)
        {
            return taiSanRepository.Create(obj);
        }
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="obj"></param>
        public static void Update(TaiSan obj)
        {
            taiSanRepository.Update(obj);
        }
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="obj"></param>
        public static void Delete(TaiSan obj)
        {
            taiSanRepository.Delete(obj);
        }
    }
}

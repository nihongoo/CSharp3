using Models;

namespace Repositories
{
    public class LoaiTaiSanRepository : ILoaiTaiSanRepository
    {
        //Get all
        public List<LoaiTaiSan> GetAll()
        {
            using (var context = new AppDbContext.AppContext())
            {
                return context.LoaiTaiSan.ToList();
            }
        }
    }
}

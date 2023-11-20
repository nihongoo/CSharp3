using Microsoft.EntityFrameworkCore;
using Models;
namespace Repositories
{
    public class TaiSanRepository : ILoaiTaiSan
    {
        //Get all
        public List<TaiSan> GetAll()
        {
            using (var context = new AppDbContext.AppContext())
            {
                return context.TaiSan.ToList();
            }
        }
        /// <summary>
        /// Search by name
        /// </summary>
        /// <returns></returns>
        public List<TaiSan> FindByName(string value)
        {
            using (var context = new AppDbContext.AppContext())
            {
                return context.TaiSan.Where(n => n.TenTaiSan.Contains(value)).ToList();
            }
        }
        /// <summary>
        /// Filter by used state
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<TaiSan> FilterByUsedState(string value)
        {
            using (var context = new AppDbContext.AppContext())
            {
                return context.TaiSan.Where(n => n.TrangThaiSD.Contains(value)).ToList();
            }
        }
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public TaiSan Create(TaiSan obj)
        {
            using (var context = new AppDbContext.AppContext())
            {
                context.TaiSan.Add(obj);
                context.SaveChanges();
                return obj;
            }
        }
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="obj"></param>
        public void Update(TaiSan obj)
        {
            if (obj != null)
            {
                using (var context = new AppDbContext.AppContext())
                {
                    context.TaiSan.Attach(obj);
                    context.Entry(obj).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="obj"></param>
        public void Delete(TaiSan obj)
        {
            using (var context = new AppDbContext.AppContext())
            {
                context.TaiSan.Attach(obj);
                context.TaiSan.Remove(obj);
                context.SaveChanges();
            }
        }
    }
}

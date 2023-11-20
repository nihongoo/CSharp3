using Models;

namespace Repositories
{
    public interface ILoaiTaiSan
    {
        List<TaiSan> GetAll();
        List<TaiSan> FindByName(string value);
        List<TaiSan> FilterByUsedState(string value);
        public TaiSan Create(TaiSan obj);
        public void Update(TaiSan obj);
        public void Delete(TaiSan obj);
    }
}

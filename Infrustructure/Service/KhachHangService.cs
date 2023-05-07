using Infrastructure.Entities;
using Infrastructure.Repository;
using System.Linq;

namespace Infrastructure.Service
{
    public interface IKhachHangService
    {
        IQueryable<KhachHang> GetKhachHangs();
        KhachHang GetKhachHang(int id);
        void InsertKhachHang(KhachHang KhachHang);
        void UpdateKhachHang(KhachHang KhachHang);
        void DeleteKhachHang(KhachHang KhachHang);
    }

    public class KhachHangService : IKhachHangService
    {
        private IKhachHangRepository khachhangRepository;

        public KhachHangService(IKhachHangRepository khachhangRepository)
        {
            this.khachhangRepository = khachhangRepository;
        }

        public IQueryable<KhachHang> GetKhachHangs()
        {
            return khachhangRepository.GetAll();
        }

        public KhachHang GetKhachHang(int id)
        {
            return khachhangRepository.GetById(id);
        }

        public void InsertKhachHang(KhachHang KhachHang)
        {
            khachhangRepository.Insert(KhachHang);
        }

        public void UpdateKhachHang(KhachHang KhachHang)
        {
            khachhangRepository.Update(KhachHang);
        }

        public void DeleteKhachHang(KhachHang KhachHang)
        {
            khachhangRepository.Delete(KhachHang);
        }
    }
}

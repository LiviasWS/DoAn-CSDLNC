using DoAN_CSDLNC.DAL;
using Hethongbancafe.CafeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using DoAN_CSDLNC.Models;

namespace DoAN_CSDLNC.BLL
{
    public class NguyenLieuBLL
    {
        private readonly NguyenLieuDAL _nguyenLieuDAL;

        public NguyenLieuBLL()
        {
            _nguyenLieuDAL = new NguyenLieuDAL();
        }

        public void AddNguyenLieu(NguyenLieu nl)
        {
            if (nl == null) throw new ArgumentNullException(nameof(nl));

            if (string.IsNullOrWhiteSpace(nl.Name))
                throw new ArgumentException("Tên nguyên liệu không được để trống.");

            if (string.IsNullOrWhiteSpace(nl.SKU))
                throw new ArgumentException("Mã SKU không được để trống.");

            if (nl.PriceIn.HasValue && nl.PriceIn.Value < 0)
                throw new ArgumentException("Giá nhập không được âm.");

            if ((nl.MinStock ?? 0) < 0 || (nl.MaxStock ?? 0) < 0)
                throw new ArgumentException("Tồn kho tối thiểu / tối đa không được âm.");

            if ((nl.MinStock ?? 0) > (nl.MaxStock ?? int.MaxValue))
                throw new ArgumentException("Tồn kho tối thiểu không thể lớn hơn tồn kho tối đa.");

            var all = _nguyenLieuDAL.GetAllNguyenLieus();
            bool exists = all.Any(x => !string.IsNullOrEmpty(x.SKU) &&
                                       x.SKU.Equals(nl.SKU, StringComparison.OrdinalIgnoreCase));
            if (exists) throw new InvalidOperationException("Mã SKU đã tồn tại.");

            _nguyenLieuDAL.AddNguyenLieu(nl);
        }

        public List<NguyenLieu> GetAllNguyenLieus()
        {
            return _nguyenLieuDAL.GetAllNguyenLieus();
        }

        public NguyenLieu GetNguyenLieuById(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentException("ID không hợp lệ.");

            var nl = _nguyenLieuDAL.GetNguyenLieuById(id);
            if (nl == null)
                throw new KeyNotFoundException("Không tìm thấy nguyên liệu có ID này.");

            return nl;
        }

        public void UpdateNguyenLieu(string id, NguyenLieu updated)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentException("ID không hợp lệ.");
            if (updated == null) throw new ArgumentNullException(nameof(updated));

            var existing = _nguyenLieuDAL.GetNguyenLieuById(id)
                          ?? throw new KeyNotFoundException("Không tìm thấy nguyên liệu.");

            if (updated.PriceIn.HasValue && updated.PriceIn.Value < 0)
                throw new ArgumentException("Giá nhập không được âm.");

            _nguyenLieuDAL.UpdateNguyenLieu(id, updated);
        }

        public void DeleteNguyenLieu(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentException("ID không hợp lệ.");

            var existing = _nguyenLieuDAL.GetNguyenLieuById(id);
            if (existing == null)
                throw new KeyNotFoundException("Không tìm thấy nguyên liệu để xóa.");

            _nguyenLieuDAL.DeleteNguyenLieu(id);
        }

        public List<NguyenLieu> GetNguyenLieuSapHetHang()
        {
            var all = _nguyenLieuDAL.GetAllNguyenLieus();
            return all.Where(x =>
                x.MinStock.HasValue && x.MaxStock.HasValue &&
                x.MaxStock.Value > 0 &&
                x.MinStock.Value >= x.MaxStock.Value * 0.9m
            ).ToList();
        }

     

        public List<NguyenLieu> GetNguyenLieuSapHetHan()
        {
            var all = _nguyenLieuDAL.GetAllNguyenLieus();
            var now = DateTime.UtcNow;

            return all.Where(x =>
                x.ExpDate.HasValue &&
                (x.ExpDate.Value - now).TotalDays <= 30
            ).ToList();
        }

        public List<string> GetAllWarehouses()
        {
            var all = _nguyenLieuDAL.GetAllNguyenLieus();
            return all
                .Where(x => !string.IsNullOrEmpty(x.Warehouse))
                .Select(x => x.Warehouse)
                .Distinct()
                .OrderBy(x => x)
                .ToList();
        }
        public List<NguyenLieu> SearchNguyenLieu(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return _nguyenLieuDAL.GetAllNguyenLieus();

            keyword = keyword.Trim();
            var all = _nguyenLieuDAL.GetAllNguyenLieus();

            return all.Where(x =>
                (!string.IsNullOrEmpty(x.SKU) && x.SKU.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrEmpty(x.Name) && x.Name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
            ).ToList();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA.Entity;

namespace DATA.NhanVien
{
    public class mapNhanVien
    {
        QLNSuEntities db = new QLNSuEntities();
        public List<NHANVIEN> GetDanhSach()
        {
            
            var danhsach = db.NHANVIEN.ToList();
            return danhsach;
        }

        public NHANVIEN GetChiTiet(string id)
        {
            var doituong = db.NHANVIEN.Find(1);
            return doituong;
        }
        
        
    }
}

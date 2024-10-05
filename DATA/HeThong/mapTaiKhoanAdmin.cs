using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA.Entity;

namespace DATA.HeThong
{
    public class mapTaiKhoanAdmin : DBConfig
    {
        public List<TAIKHOANADMIN> Danhsach()
        {
            try
            {
                return db.TAIKHOANADMIN.ToList();
            }
            catch (Exception)
            {

                return new List<TAIKHOANADMIN>();
            }
        }
        public TAIKHOANADMIN ChiTiet(string user, string pass)
        {
            try
            {
                var data = db.TAIKHOANADMIN.SingleOrDefault(m => m.TENDANGNHAP.ToLower() == user.ToLower() & m.MATKHAU == pass);
                return data;

            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}

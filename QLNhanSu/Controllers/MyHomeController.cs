using DATA.NhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DATA.Entity;
using DATA.HeThong;

namespace QLNhanSu.Controllers
{
    public class MyHomeController : Controller
    {
        public object SessionConfig { get; private set; }
        QLNSuEntities db = new QLNSuEntities();
        // GET: MyHome
        public ActionResult MyHome()
        {
            return View();
        }
        // Nhân viên

        public ActionResult Nhanvien()
        {
            QLNSuEntities db = new QLNSuEntities();
            List<NHANVIEN> dsnv = db.NHANVIEN.ToList();
           // List<NHANVIEN> dsnv = db.NHANVIEN.Where(row => row.HOTEN.Contains(table_search)).ToList();
            return View(dsnv);
        }
        public ActionResult CreateNv()
        {
            return View();
        }
      
        [HttpPost]
        public ActionResult CreateNv(NHANVIEN nv)
       {
         
          QLNSuEntities db = new QLNSuEntities();
           db.NHANVIEN.Add(nv);
          db.SaveChanges();
          return RedirectToAction("nhanvien");
       }
    
        //Phòng ban
        public ActionResult PhongBan()
        {
            QLNSuEntities db = new QLNSuEntities();
            List<PHONGBAN> dspb = db.PHONGBAN.ToList();
            return View(dspb);
        }
        public ActionResult CreatePb()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePb(PHONGBAN pb)
        {

            QLNSuEntities db = new QLNSuEntities();
            db.PHONGBAN.Add(pb);
            db.SaveChanges();
            return RedirectToAction("phongban");
        }
        //Hợp đồng
        public ActionResult HopDong()
        {
            QLNSuEntities db = new QLNSuEntities();
            List<HOPDONG> dshd = db.HOPDONG.ToList();
            return View(dshd);
        }
        public ActionResult CreateHD()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateHD(HOPDONG hd)
        {

            QLNSuEntities db = new QLNSuEntities();
            db.HOPDONG.Add(hd);
            db.SaveChanges();
            return RedirectToAction("hopdong");
        }
        //Bảo hiểm
        public ActionResult BaoHiem()
        {
            return View();
        }
        //Y tế
        public ActionResult BaoHiemYTE()
        {
            QLNSuEntities db = new QLNSuEntities();
            List<BHYT> dsyt = db.BHYT.ToList();
            return View(dsyt); 
        }
        public ActionResult CreateYT()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateYT(BHYT yt)
        {

            QLNSuEntities db = new QLNSuEntities();
            db.BHYT.Add(yt);
            db.SaveChanges();
            return RedirectToAction("baohiemyte");
        }
        //XH
        public ActionResult BaoHiemXH()
        {
            QLNSuEntities db = new QLNSuEntities();
            List<BHXH> dsxh = db.BHXH.ToList();
            return View(dsxh);
        }
        public ActionResult CreateXH()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateXH(BHXH xh)
        {

            QLNSuEntities db = new QLNSuEntities();
            db.BHXH.Add(xh);
            db.SaveChanges();
            return RedirectToAction("baohiemxh");
        }
        //nghỉ phép
        public ActionResult NghiPhep()
        {
            QLNSuEntities db = new QLNSuEntities();
            List<PHIEUNGHIPHEP> dsnp = db.PHIEUNGHIPHEP.ToList();
            return View(dsnp);
        }
        public ActionResult CreateNP()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNv(PHIEUNGHIPHEP np)
        {

            QLNSuEntities db = new QLNSuEntities();
            db.PHIEUNGHIPHEP.Add(np);
            db.SaveChanges();
            return RedirectToAction("nghiphep");
        }
        //Lương
        public ActionResult Luong()
        {
            QLNSuEntities db = new QLNSuEntities();
            List<PHIEULUONG> dsl = db.PHIEULUONG.ToList();
            return View(dsl);
        }
        public ActionResult CreatePL()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePL(PHIEULUONG pl)
        {

            QLNSuEntities db = new QLNSuEntities();
            db.PHIEULUONG.Add(pl);
            db.SaveChanges();
            return RedirectToAction("phieuluong");
        }
        //Dang nhap
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(string user, string pass)
        {
            var map = new mapTaiKhoanAdmin();
            var taikhoan = map.ChiTiet(user, pass);
            if(taikhoan == null)
            {
                return View();
            }
            return RedirectToAction("MyHome");
        }


    }

   
}
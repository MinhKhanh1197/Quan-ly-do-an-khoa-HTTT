using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebQLDAKhoaHTTT.Models;

namespace WebQLDAKhoaHTTT.Controllers
{
    public class HomeController : Controller
    {
        QuanLyDADBEntities1 db = new QuanLyDADBEntities1();
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Xemchitiet(int MaDA)
        {
            DOAN doan = db.DOANs.SingleOrDefault(n=>n.MaDA==MaDA);
            if(doan == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(doan);
        }

        public ActionResult FrmDKDA()
        {
            var dkda = (from dn in db.CHUDEs select dn).ToList();
            return View(dkda);
        }
        public ActionResult FrmNopDA()
        {
            var nopda = (from nop in db.CHUDEs select nop).ToList();
            return View(nopda);
        }
        public ActionResult DSDoAn()
        {
            return View();
        }
        public ActionResult DangNhap()
        {
            var dntk = (from dn in db.Users select dn).ToList();
            return View(dntk);
        }
        public ActionResult DSGiangVien()
        {
            var dsgv = (from gv in db.GIANGVIENs select gv).ToList();
            return View(dsgv);
        }
        public ActionResult DSSinhVien()
        {
            var dssv = (from sv in db.SINHVIENs select sv).ToList();
            return View(dssv);
        }
        public ActionResult GopY()
        {
            return View();
        }
    }
}
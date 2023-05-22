using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnThi1.Models;
using System.Diagnostics;

namespace OnThi1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QlbanVaLiContext _context = new QlbanVaLiContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var sanpham = _context.TDanhMucSps.ToList();
            return View(sanpham);
        }
        public IActionResult ChiTietSanPham (string masanpham)
        {
            var sp = _context.TDanhMucSps.AsNoTracking().FirstOrDefault(x=>x.MaSp == masanpham);
            return View(sp);
        }
        public IActionResult SuaSanPham(string masanpham)
        {
            var sp = _context.TDanhMucSps.AsNoTracking().FirstOrDefault(x => x.MaSp == masanpham);
            ViewBag.MaChatLieu = new SelectList(_context.TChatLieus.ToList(), "MaChatLieu", "ChatLieu");
            ViewBag.MaHangSx = new SelectList(_context.THangSxes.ToList(), "MaHangSx", "HangSx");
            ViewBag.MaNuocSx = new SelectList(_context.TQuocGia.ToList(), "MaNuoc", "TenNuoc");
            ViewBag.MaLoai = new SelectList(_context.TLoaiSps.ToList(), "MaLoai", "Loai");
            ViewBag.MaDt = new SelectList(_context.TLoaiDts.ToList(), "MaDt", "TenLoai");
            return View(sp);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnThi1.Models;

namespace OnThi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamTheoLoai : ControllerBase
    {
        private readonly QlbanVaLiContext _context = new QlbanVaLiContext();
        [HttpGet("{loaisp}")] 
        public IEnumerable<TDanhMucSp> GetSanPham(string loaisp)
        {
            var sanpham = _context.TDanhMucSps.Where(x => x.MaLoai == loaisp).ToList();         
            return sanpham;
        }
    }
}

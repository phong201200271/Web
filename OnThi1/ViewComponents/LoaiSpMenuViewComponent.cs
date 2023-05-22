using Microsoft.AspNetCore.Mvc;
using OnThi1.Repository;

namespace OnThi1.ViewComponents
{
    public class LoaiSpMenuViewComponent:ViewComponent
    {
        private readonly ILoaiSp _context; 
        public LoaiSpMenuViewComponent(ILoaiSp context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var loaisp = _context.GetAll();
            return View(loaisp);
        }
    }
}

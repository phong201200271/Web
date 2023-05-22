using OnThi1.Models;

namespace OnThi1.Repository
{
    public class LoaiSp:ILoaiSp
    {
        private readonly QlbanVaLiContext _context; 
        public LoaiSp(QlbanVaLiContext context)
        {
            _context = context;
        }

        public IEnumerable<TLoaiSp> GetAll()
        {
            return _context.TLoaiSps;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using Shop2.Data;
using Shop2.Models.ViewModel;

namespace Shop2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoaiMatHangController : Controller
    {
        private readonly ApplicationDbContext _db;
      //  private readonly HostingEnvironment _hostingEnvironment;

        [BindProperty]
        public LoaiMatHangViewModel LoaiMatHangVM { get; set; }
        public LoaiMatHangController(ApplicationDbContext db)//, HostingEnvironment hostingEnvironment)
        {
            _db = db;
          //  _hostingEnvironment = hostingEnvironment;
            LoaiMatHangVM = new LoaiMatHangViewModel()
            {
                GianHangs = _db.GianHangs.ToList(),
                LoaiMatHang = new Models.LoaiMatHang()
            };
        }
        public async Task<IActionResult> Index()
        {
            var loaiMatHang = _db.LoaiMatHangs.Include(m => m.GianHang);
            return View(await loaiMatHang.ToListAsync());
        }
        public async Task<IActionResult> CreatePOST()
        {
            if (!ModelState.IsValid)
            {
                return View(LoaiMatHangVM);
            }

            _db.LoaiMatHangs.Add(LoaiMatHangVM.Products);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }


    }
}
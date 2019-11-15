using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using Shop2.Data;
using Shop2.Models;
using Shop2.Models.ViewModel;
using Shop2.Utility;

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
        public IActionResult Create()
        {
            return View(LoaiMatHangVM);
        }

        //Post : Products Create
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
        {
            if (!ModelState.IsValid)
            {
                return View(LoaiMatHangVM);
            }

            _db.LoaiMatHangs.Add(LoaiMatHangVM.LoaiMatHang);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        //GET : Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LoaiMatHangVM.LoaiMatHang = await _db.LoaiMatHangs.Include(m => m.GianHang).SingleOrDefaultAsync(m => m.MatHangId == id);

            if (LoaiMatHangVM.LoaiMatHang == null)
            {
                return NotFound();
            }

            return View(LoaiMatHangVM);
        }


        //Post : Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            if (ModelState.IsValid)
            {
              //  string webRootPath = _hostingEnvironment.WebRootPath;
               // var files = HttpContext.Request.Form.Files;

                var LMHFromDb = _db.LoaiMatHangs.Where(m => m.MatHangId == LoaiMatHangVM.LoaiMatHang.MatHangId).FirstOrDefault();

                //if (files.Count > 0 && files[0] != null)
                //{
                //    //if user uploads a new image
                //    var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                //    var extension_new = Path.GetExtension(files[0].FileName);
                //    var extension_old = Path.GetExtension(productFromDb.Image);

                //    if (System.IO.File.Exists(Path.Combine(uploads, ProductsVM.Products.Id + extension_old)))
                //    {
                //        System.IO.File.Delete(Path.Combine(uploads, ProductsVM.Products.Id + extension_old));
                //    }
                //    using (var filestream = new FileStream(Path.Combine(uploads, ProductsVM.Products.Id + extension_new), FileMode.Create))
                //    {
                //        files[0].CopyTo(filestream);
                //    }
                //    ProductsVM.Products.Image = @"\" + SD.ImageFolder + @"\" + ProductsVM.Products.Id + extension_new;
                //}

                //if (ProductsVM.Products.Image != null)
                //{
                //    productFromDb.Image = ProductsVM.Products.Image;
                //}

                LMHFromDb.TenMatHang = LoaiMatHangVM.LoaiMatHang.TenMatHang;
                LMHFromDb.MoTaMatHang = LoaiMatHangVM.LoaiMatHang.MoTaMatHang;
                LMHFromDb.GianHangId = LoaiMatHangVM.LoaiMatHang.GianHangId;
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(LoaiMatHangVM);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LoaiMatHangVM.LoaiMatHang = await _db.LoaiMatHangs.Include(m => m.GianHang).SingleOrDefaultAsync(m => m.MatHangId == id);

            if (LoaiMatHangVM.LoaiMatHang == null)
            {
                return NotFound();
            }

            return View(LoaiMatHangVM);
        }

        //POST : Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
          //  string webRootPath = _hostingEnvironment.WebRootPath;
            LoaiMatHang loaiMatHang = await _db.LoaiMatHangs.FindAsync(id);

            if (loaiMatHang == null)
            {
                return NotFound();
            }
            else
            {
                //var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                //var extension = Path.GetExtension(products.Image);

                //if (System.IO.File.Exists(Path.Combine(uploads, products.Id + extension)))
                //{
                //    System.IO.File.Delete(Path.Combine(uploads, products.Id + extension));
                //}
                _db.LoaiMatHangs.Remove(loaiMatHang);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
        }

        //GET : Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LoaiMatHangVM.LoaiMatHang = await _db.LoaiMatHangs.Include(m => m.GianHang).SingleOrDefaultAsync(m => m.MatHangId == id);

            if (LoaiMatHangVM.LoaiMatHang == null)
            {
                return NotFound();
            }

            return View(LoaiMatHangVM);
        }


    }
}
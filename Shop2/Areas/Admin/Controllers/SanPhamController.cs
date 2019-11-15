using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using Shop2.Data;
using Shop2.Models;
using Shop2.Utility;

namespace Shop2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SanPhamController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHostingEnvironment _hostingEnvironment;
        

        public SanPhamController(ApplicationDbContext db, IHostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;

        }
        public IActionResult Index()
        {
            return View(_db.SanPhams.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST(SanPham sanPham)
        {
            if (!ModelState.IsValid)
            {
                return View(sanPham);
            }

            _db.SanPhams.Add(sanPham);
            await _db.SaveChangesAsync();

            //Image being saved

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var productsFromDb = _db.SanPhams.Find(sanPham.SanPhamId);

            if (files.Count != 0)
            {
                //Image has been uploaded
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(files[0].FileName);

                using (var filestream = new FileStream(Path.Combine(uploads, sanPham.SanPhamId + extension), FileMode.Create))
                {
                    files[0].CopyTo(filestream);
                }
                productsFromDb.Image = @"\" + SD.ImageFolder + @"\" + sanPham.SanPhamId + extension;
            }
            else
            {
                //when user does not upload image
                var uploads = Path.Combine(webRootPath, SD.ImageFolder + @"\" + SD.DefaultProductImage);
                System.IO.File.Copy(uploads, webRootPath + @"\" + SD.ImageFolder + @"\" + sanPham.SanPhamId + ".png");
                productsFromDb.Image = @"\" + SD.ImageFolder + @"\" + sanPham.SanPhamId + ".png";
            }
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sanPham = await _db.SanPhams.FindAsync(id);
            if (sanPham == null)
            {
                return NotFound();
            }
            return View(sanPham);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                string webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;

                var productFromDb = _db.SanPhams.Where(m => m.SanPhamId == sanPham.SanPhamId).FirstOrDefault();

                if (files.Count > 0 && files[0] != null)
                {
                    //if user uploads a new image
                    var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                    var extension_new = Path.GetExtension(files[0].FileName);
                    var extension_old = Path.GetExtension(productFromDb.Image);

                    if (System.IO.File.Exists(Path.Combine(uploads, sanPham.SanPhamId + extension_old)))
                    {
                        System.IO.File.Delete(Path.Combine(uploads, sanPham.SanPhamId + extension_old));
                    }
                    using (var filestream = new FileStream(Path.Combine(uploads, sanPham.SanPhamId + extension_new), FileMode.Create))
                    {
                        files[0].CopyTo(filestream);
                    }
                    sanPham.Image = @"\" + SD.ImageFolder + @"\" + sanPham.SanPhamId + extension_new;
                }

                if (sanPham.Image != null)
                {
                    productFromDb.Image = sanPham.Image;
                }

                productFromDb.TenSanPham = sanPham.TenSanPham;
                productFromDb.MotaSP = sanPham.MotaSP;
                productFromDb.Gia = sanPham.Gia;
                productFromDb.TacGia = sanPham.TacGia;
                productFromDb.NXB = sanPham.NXB;
                productFromDb.NgonNgu = sanPham.NgonNgu;
                productFromDb.NgayThem = sanPham.NgayThem;
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sanPham);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sanPham = await _db.SanPhams.FindAsync(id);
            if (sanPham == null)
            {
                return NotFound();
            }
            return View(sanPham);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sanPham = await _db.SanPhams.FindAsync(id);
            if (sanPham == null)
            {
                return NotFound();
            }
            return View(sanPham);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            string webRootPath = _hostingEnvironment.WebRootPath;

            SanPham sanPham = await _db.SanPhams.FindAsync(id);
            if(sanPham==null)
            {
                return NotFound();
            }
            else
            {
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(sanPham.Image);
                if (System.IO.File.Exists(Path.Combine(uploads,sanPham.SanPhamId+extension)))
                {
                    System.IO.File.Delete(Path.Combine(uploads, sanPham.SanPhamId + extension)); 
                }
            }
            _db.SanPhams.Remove(sanPham);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
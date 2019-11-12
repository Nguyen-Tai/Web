using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop2.Data;
using Shop2.Models;

namespace Shop2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GianHangController : Controller
    {
        private readonly ApplicationDbContext _db;

        public GianHangController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.GianHangs.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GianHang gianHang)
        {
            if (ModelState.IsValid)
            {
                _db.Add(gianHang);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(gianHang);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var gianHang = await _db.GianHangs.FindAsync(id);
            if (gianHang == null)
            {
                return NotFound();
            }
            return View(gianHang);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, GianHang gianHang)
        {
            if (id != gianHang.GianHangId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Update(gianHang);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gianHang);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var gianHang = await _db.GianHangs.FindAsync(id);
            if (gianHang == null)
            {
                return NotFound();
            }
            return View(gianHang);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var gianHang = await _db.GianHangs.FindAsync(id);
            if (gianHang == null)
            {
                return NotFound();
            }
            return View(gianHang);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gianHang = await _db.GianHangs.FindAsync(id);
            _db.GianHangs.Remove(gianHang);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}

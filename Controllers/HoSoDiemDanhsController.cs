using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuanLyTruongHoc.Models;
using QuanLyTruongHoc.Models.QuanLyNghiepVu;

namespace QuanLyTrungTam.Controllers
{
    public class HoSoDiemDanhsController : Controller
    {
        private readonly QuanLyTruongHocConText _context;

        public HoSoDiemDanhsController(QuanLyTruongHocConText context)
        {
            _context = context;
        }

        // GET: HoSoDiemDanhs
        public async Task<IActionResult> Index()
        {
            int today = ((int)DateTime.Now.DayOfWeek == 0) ? 7 : (int)DateTime.Now.DayOfWeek;
            today++;

            var listTKB = _context.tKBItems.Where(p => p.day == today.ToString());
            var lstClass = _context.classes.Where(p => listTKB.Any(t => t.IdLop == p.Id)).ToList();

            return _context.hoSoDiemDanhs != null ? 
                          View(lstClass) :
                          Problem("Entity set 'QuanLyTruongHocConText.hoSoDiemDanhs'  is null.");
        }

        public async Task<IActionResult> DiemDanh(List<int> listVang)
        {
            foreach(var item in listVang)
            {
                var hoso = new HoSoDiemDanh();
                hoso.ngay = DateTime.Today;
                hoso.IdHocSinh = item;

                _context.Add(hoso);
                await _context.SaveChangesAsync();

            }

            return RedirectToAction("ListVang", "HoSoDiemDanhs");
        }

        public IActionResult ListVang()
        {
            var listVang = _context.hoSoDiemDanhs.Where(p => p.ngay == DateTime.Today).ToList();

            return View(listVang);
        }

        // GET: HoSoDiemDanhs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.hoSoDiemDanhs == null)
            {
                return NotFound();
            }

            var hoSoDiemDanh = await _context.hoSoDiemDanhs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hoSoDiemDanh == null)
            {
                return NotFound();
            }

            return View(hoSoDiemDanh);
        }

        // GET: HoSoDiemDanhs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HoSoDiemDanhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdHocSinh,ngay")] HoSoDiemDanh hoSoDiemDanh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoSoDiemDanh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hoSoDiemDanh);
        }

        // GET: HoSoDiemDanhs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.hoSoDiemDanhs == null)
            {
                return NotFound();
            }

            var hoSoDiemDanh = await _context.hoSoDiemDanhs.FindAsync(id);
            if (hoSoDiemDanh == null)
            {
                return NotFound();
            }
            return View(hoSoDiemDanh);
        }

        // POST: HoSoDiemDanhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdHocSinh,ngay")] HoSoDiemDanh hoSoDiemDanh)
        {
            if (id != hoSoDiemDanh.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoSoDiemDanh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoSoDiemDanhExists(hoSoDiemDanh.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(hoSoDiemDanh);
        }

        // GET: HoSoDiemDanhs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.hoSoDiemDanhs == null)
            {
                return NotFound();
            }

            var hoSoDiemDanh = await _context.hoSoDiemDanhs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hoSoDiemDanh == null)
            {
                return NotFound();
            }

            return View(hoSoDiemDanh);
        }

        // POST: HoSoDiemDanhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.hoSoDiemDanhs == null)
            {
                return Problem("Entity set 'QuanLyTruongHocConText.hoSoDiemDanhs'  is null.");
            }
            var hoSoDiemDanh = await _context.hoSoDiemDanhs.FindAsync(id);
            if (hoSoDiemDanh != null)
            {
                _context.hoSoDiemDanhs.Remove(hoSoDiemDanh);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoSoDiemDanhExists(int id)
        {
          return (_context.hoSoDiemDanhs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

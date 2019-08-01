using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assessment6b.Models;

namespace Assessment6b.Controllers
{
    public class JellyBeansController : Controller
    {
        private readonly JellyBeanContext _context;

        public JellyBeansController(JellyBeanContext context)
        {
            _context = context;
        }

        // GET: JellyBeans
        public async Task<IActionResult> Index()
        {
            return View(await _context.JellyBeans.ToListAsync());
        }

        // GET: JellyBeans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jellyBean = await _context.JellyBeans
                .FirstOrDefaultAsync(m => m.JellyBeanId == id);
            if (jellyBean == null)
            {
                return NotFound();
            }

            return View(jellyBean);
        }

        // GET: JellyBeans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JellyBeans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JellyBeanId,Style,Rating")] JellyBean jellyBean)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jellyBean);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jellyBean);
        }

        // GET: JellyBeans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jellyBean = await _context.JellyBeans.FindAsync(id);
            if (jellyBean == null)
            {
                return NotFound();
            }
            return View(jellyBean);
        }

        // POST: JellyBeans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JellyBeanId,Style,Rating")] JellyBean jellyBean)
        {
            if (id != jellyBean.JellyBeanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jellyBean);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JellyBeanExists(jellyBean.JellyBeanId))
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
            return View(jellyBean);
        }

        // GET: JellyBeans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jellyBean = await _context.JellyBeans
                .FirstOrDefaultAsync(m => m.JellyBeanId == id);
            if (jellyBean == null)
            {
                return NotFound();
            }

            return View(jellyBean);
        }

        // POST: JellyBeans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jellyBean = await _context.JellyBeans.FindAsync(id);
            _context.JellyBeans.Remove(jellyBean);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JellyBeanExists(int id)
        {
            return _context.JellyBeans.Any(e => e.JellyBeanId == id);
        }
    }
}

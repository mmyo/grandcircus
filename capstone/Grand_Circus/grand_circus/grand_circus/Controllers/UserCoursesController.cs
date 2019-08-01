using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using grand_circus.Models;
using Microsoft.AspNetCore.Http;

namespace grand_circus.Controllers
{
    public class UserCoursesController : Controller
    {
        private readonly ISession _session;
        private readonly GrandCircusContext _context;

        public UserCoursesController(GrandCircusContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _session = httpContextAccessor.HttpContext.Session;

        }

        // GET: UserCourses
        public async Task<IActionResult> Index()
        {
            var grandCircusContext = _context.UserCourses.Include(u => u.Course).Include(u => u.User);
            return View(await grandCircusContext.ToListAsync());
        }

        // GET: UserCourses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userCourses = await _context.UserCourses
                .Include(u => u.Course)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.UserCoursesId == id);
            if (userCourses == null)
            {
                return NotFound();
            }

            return View(userCourses);
        }

        // GET: UserCourses/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId");
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId");
            return View();
        }

        // POST: UserCourses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserCoursesId,UserId,CourseId,Semester,Grade")] UserCourses userCourses)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userCourses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId", userCourses.CourseId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", userCourses.UserId);
            return View(userCourses);
        }

        // GET: UserCourses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userCourses = await _context.UserCourses.FindAsync(id);
            if (userCourses == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId", userCourses.CourseId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", userCourses.UserId);
            return View(userCourses);
        }

        // POST: UserCourses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserCoursesId,UserId,CourseId,Semester,Grade")] UserCourses userCourses)
        {
            if (id != userCourses.UserCoursesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userCourses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserCoursesExists(userCourses.UserCoursesId))
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
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId", userCourses.CourseId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", userCourses.UserId);
            return View(userCourses);
        }

        // GET: UserCourses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userCourses = await _context.UserCourses
                .Include(u => u.Course)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.UserCoursesId == id);
            if (userCourses == null)
            {
                return NotFound();
            }

            return View(userCourses);
        }

        // POST: UserCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userCourses = await _context.UserCourses.FindAsync(id);
            _context.UserCourses.Remove(userCourses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserCoursesExists(int id)
        {
            return _context.UserCourses.Any(e => e.UserCoursesId == id);
        }

        public IActionResult ViewCoursesByUserId()
        {
            // view with search field (userId) and button

            return View();
        }

        [HttpPost]
        public IActionResult ViewCoursesByUserId(UserCourses userCourses)
        {
            //select * from userCourses where userCourses.userId = userId
            

            if (ModelState.IsValid)
            {
                var grandCircusContext = _context.UserCourses.Where(x => x.UserId == userCourses.UserId).ToList();
                return RedirectToAction("DisplayCoursesByUserId", grandCircusContext);
            }
            else
            {
                return View();                  
            }

            //return View();
            //.Where(u => u.UserId == userCourses.UserId).ToList()
        }
    }
}

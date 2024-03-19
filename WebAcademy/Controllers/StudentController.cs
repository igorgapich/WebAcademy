using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAcademy.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext _context;
        public StudentController(StudentDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Students.ToList());
            //return View("Index");
        }

        public IActionResult Details(int id)
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        
        public IActionResult Delete(int id)
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            _context.Students.Remove(student);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}


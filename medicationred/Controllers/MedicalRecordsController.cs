using medicationred.Data;
using medicationred.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;


namespace medicationred.Controllers
{
    [Authorize(Roles = "Лекар, Администратор")]
    public class MedicalRecordsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MedicalRecordsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var records = _context.MedicalRecords.Include(m => m.User).ToList();
            return View(records);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(MedicalRecord record)
        {
            if (ModelState.IsValid)
            {
                record.DateCreated = DateTime.Now;
                _context.MedicalRecords.Add(record);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(record);
        }
    }
}

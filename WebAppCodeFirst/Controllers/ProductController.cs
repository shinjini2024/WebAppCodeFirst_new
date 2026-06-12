using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppCodeFirst.Models;

namespace WebAppCodeFirst.Controllers
{
    public class ProductController : Controller
    {
        ProjectContext _db;
        public ProductController(ProjectContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            //var result = (from test in _db.tblProduct
            //              select test).ToList();
            var result = await _db.tblProduct.ToListAsync();
            return View(result);
        }
        public async Task<IActionResult> Details(int id)
        {
            var row =await  _db.tblProduct.Where(a => a.Pid == id).FirstOrDefaultAsync();//lambda expression
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product obj)
        {
            try
            {
               await  _db.tblProduct.AddAsync(obj);
               await _db.SaveChangesAsync();
                TempData["Message"] = "Insert Success";
            }
            catch (Exception ex)
            {
                TempData["Message"] = "Insert Failure";
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var row =await  _db.tblProduct.Where(a => a.Pid == id).FirstOrDefaultAsync();
                 _db.tblProduct.Remove(row);
                await _db.SaveChangesAsync();
                TempData["Message"] = "Delete Success";
            }
            catch (Exception ex)
            {
                TempData["Message"] = "Delete Failure";
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var row = await _db.tblProduct.Where(a => a.Pid == id).FirstOrDefaultAsync();
            return View(row);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Product obj)
        {
            try
            {
                _db.tblProduct.Update(obj);
                await _db.SaveChangesAsync();
                TempData["Message"] = "Update Success";
            }
            catch (Exception ex)
            {
                TempData["Message"] = "Update Failure";
            }
            return RedirectToAction("Index");
        }
    }
}

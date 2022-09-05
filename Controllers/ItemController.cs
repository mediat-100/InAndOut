using System.Collections.Generic;
using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class ItemController : Controller
    {

        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }

        //GET - Create
        public IActionResult Create()
        {
            return View();
        }

        //POST - Create
        [HttpPost]
        [ValidateAntiForgeryToken]  // checks if we are still logged in
        public IActionResult Create(Item obj)
        {
            _db.Items.Add(obj); // To add the create object to database
            _db.SaveChanges();  // To save to DB
            return RedirectToAction("Index"); //Redirects to index action
        }


    }
}

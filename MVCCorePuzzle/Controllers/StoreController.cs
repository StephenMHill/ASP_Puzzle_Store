using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCorePuzzle.Data;

namespace MVCCorePuzzle.Controllers
{
    public class StoreController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StoreController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var genres = _db.Genres.ToList();
            return View(genres);
        }
    }
}
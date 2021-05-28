using BookStore_2._0.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_2._0.Entities.Store;
using Microsoft.EntityFrameworkCore;

namespace BookStore_2._0.Controllers
{
    public class HomeController : Controller
    {
		private BookContext db;
		public HomeController(BookContext context)
		{
			db = context;
		}
		public async Task<IActionResult> Index()
		{
			return View(await db.Books.ToListAsync());
		}
	}
}
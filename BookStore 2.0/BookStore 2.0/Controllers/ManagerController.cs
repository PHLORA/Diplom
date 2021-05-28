using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_2._0.Entities.Store;
using BookStore_2._0.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore_2._0.Controllers
{
	
	public class ManagerController : Controller
	{
		private BookContext db;
		public ManagerController(BookContext context)
		{
			db = context;
		}
		public async Task<IActionResult> Index()
		{
			return View(await db.Books.ToListAsync());
		}
		public IActionResult Create()
		{
			return View();	
		}
		[HttpPost]
		public async Task<IActionResult> Create(Book book)
		{
			db.Books.Add(book);
			await db.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Edit(int? id)
		{
			if (id != null)
			{
				Book book = await db.Books.FirstOrDefaultAsync(p => p.Id == id);
				if (book != null)
					return View(book);
			}
			return NotFound();
		}
		[HttpPost]
		public async Task<IActionResult> Edit(Book book)
		{
			db.Books.Update(book);
			await db.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		[HttpPost]
		public async Task<IActionResult> Delete(int? id)
		{
			if (id != null)
			{
				Book book = await db.Books.FirstOrDefaultAsync(p => p.Id == id);
				if (book != null)
				{
					db.Books.Remove(book);
					await db.SaveChangesAsync();
					return RedirectToAction("Index");
				}
			}
			return NotFound();
		}
	}
}

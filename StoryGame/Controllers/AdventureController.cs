using Microsoft.AspNetCore.Mvc;
using StoryGame.Data;
using StoryGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryGame.Controllers
{
	public class AdventureController : Controller
	{
		private readonly DefaultContext _context = null;

		public AdventureController(DefaultContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			ViewBag.MyTitle = "Adventures";

			var query = from item in _context.Adventures
						select item;

			return View(query.ToList());
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Adventure adventure)
		{
			IActionResult result = View(adventure);

			if (ModelState.IsValid)
			{
				this._context.Adventures.Add(adventure);
				this._context.SaveChanges();
				result = RedirectToAction("Begin");
			}
			return result;
		}

		public IActionResult Edit(int id)
		{
			return View();
		}

		public IActionResult Begin()
		{
			return View();
		}
	}
}

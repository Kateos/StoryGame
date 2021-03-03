using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryGame.Controllers
{
	public class ParagraphController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

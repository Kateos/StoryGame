﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryGame.Controllers
{
	public class QuestionController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

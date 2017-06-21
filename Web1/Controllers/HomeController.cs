﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Web1.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index(string ajax = "false")
		{
			ViewBag.Ajax = ajax;
			if (ajax == "true")
			{
				return PartialView();
			}
			else
			{
				return View();
			}
		}
		public ActionResult About(string ajax = "false")
		{
			ViewBag.Ajax = ajax;
			if (ajax == "true")
			{
				return PartialView(new { name = "abe" });
			}
			else
			{
				return View(new { name = "abe" });
			}
		}
		public ActionResult Contacts(string ajax = "false")
		{
			ViewBag.Ajax = ajax;
			if (ajax == "true")
			{
				return PartialView(new { name = "abe" });
			}
			else
			{
				return View(new { name = "abe" });
			}
		}
	}
}
using System;
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
			Debug.WriteLine("Request.IsAjaxRequest()=" + Request.IsAjaxRequest());
			ViewBag.Ajax = ajax;
			if (ajax == "true")
			{
				return PartialView();
			}
			else
			{
				return View("None", new { });
			}
		}
		public ActionResult About(string ajax = "false", string param = "")
		{
			ViewBag.Ajax = ajax;
			if (ajax == "true")
			{
				return PartialView(new { name = "abe" });
			}
			else
			{
				return View("None",new { name = "abe", param = param });
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
				return View("None",new { name = "abe" });
			}
		}
	}
}

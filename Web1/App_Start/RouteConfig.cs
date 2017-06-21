// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="">
//   Copyright © 2014 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace App.Web1
{
	using System.Web.Routing;

	using App.Web1.Routing;

	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			//routes.Add("Default", new DefaultRoute());

			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional }
			);

		}
	}
}

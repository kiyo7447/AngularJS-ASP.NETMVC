// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BundleConfig.cs" company="">
//   Copyright © 2014 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.Web1
{
	using System.Web;
	using System.Web.Optimization;

	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new StyleBundle("~/content/css/app").Include(
				"~/content/app.css"));

			bundles.Add(new ScriptBundle("~/js/jquery").Include(
				"~/scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/js/angular").Include(
				"~/scripts/angular.min.js",
				"~/scripts/angular-ui-router.min.js",
				"~/scripts/angular-cookeis.min.js"));

			bundles.Add(new ScriptBundle("~/js/app").Include(
				"~/scripts/filters.js",
				"~/scripts/services.js",
				"~/scripts/directives.js",
				"~/scripts/controllers.js",
				"~/scripts/app.js"));
		}
	}
}

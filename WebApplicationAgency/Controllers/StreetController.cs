using Business.Interop.Data;
using Business.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAgency.Controllers
{
    public class StreetController : Controller
	{
		private readonly IStreetService _streetService;

		public StreetController(IStreetService streetService)
		{
			_streetService = streetService;
		}

		// GET: StreetController
		public ActionResult Index()
		{
			var streets = _streetService.GetStreets();
			return View(streets);
		}

		// GET: StreetController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: StreetController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: StreetController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(StreetDto dto)
		{
			if (!ModelState.IsValid)
			{
				return View(dto);
			}

			_streetService.CreateStreet(dto);

			return RedirectToAction(nameof(Index));
		}

		// GET: StreetController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: StreetController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: StreetController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: StreetController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}

}

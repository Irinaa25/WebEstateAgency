using Business.Interop.Data;
using Business.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAgency.Controllers
{
    public class TownController : Controller
	{
		private readonly ITownService _townService;

		public TownController(ITownService townService)
		{
			_townService = townService;
		}

		// GET: TownController
		public ActionResult Index()
		{
			var towns = _townService.GetTowns();
			return View(towns);
		}

		// GET: TownController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: TownController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: TownController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(TownDto dto)
		{
			if (!ModelState.IsValid)
			{
				return View(dto);
			}

			_townService.CreateTown(dto);

			return RedirectToAction(nameof(Index));
		}

		// GET: TownController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: TownController/Edit/5
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

		// GET: TownController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: TownController/Delete/5
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

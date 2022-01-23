using Business.Interop.Data;
using Business.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebApplicationAgency.Controllers
{
    public class RealtorController : Controller
	{
		private readonly IRealtorService _realtorService;
		private readonly IDealService _dealService;

		public RealtorController(IDealService dealService, IRealtorService realtorService)
		{
			_realtorService = realtorService;
			_dealService = dealService;
		}

		// GET: RealtorController
		public ActionResult Index()
		{
			var realtors = _realtorService.GetRealtors();
			return View(realtors);
		}

		// GET: RealtorController/Details/5
		public ActionResult Details(int id)
		{
			var realtor = _realtorService.GetById(id);
			var deals = _dealService.GetAll().Where(e => e.RealtorId == id);
			realtor.Deals = deals;
			return View(realtor);
		}


		public IActionResult Create(int? id)
		{
			ViewBag.Deals = _dealService.GetAll()
				.OrderBy(_ => _.ToString());
			if (id == null)
				return View();
			var realtor = _realtorService.GetById(id.Value);
			return View(realtor);
		}

		[HttpPost]
		public IActionResult Create(RealtorDto realtor)
		{
			if (!ModelState.IsValid)
				return RedirectToAction(nameof(Create), new { id = realtor.Id });
			var res = _realtorService.CreateOrUpdate(realtor);
			return RedirectToAction(nameof(Index), new { id = res.Id });
		}

		// GET: RealtorController/Delete/5
		public ActionResult Delete(int id)
		{
			var realtor = _realtorService.GetById(id);
			var deals = _dealService.GetAll().Where(_ => _.RealtorId == id);
			foreach (var d in deals)
				_dealService.Delete(d.Id);
			_realtorService.Delete(id);
			return RedirectToAction(nameof(Index));
		}
	}
}

using Business.Interop.Data;
using Business.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebApplicationAgency.Controllers
{
    public class DealController : Controller
	{
		private readonly IDealService _dealService;
		private readonly IRealtorService _realtorService;
		private readonly IClientService _clientService;

		public DealController(IRealtorService realtorService, IClientService clientService, IDealService dealService)
		{
			_dealService = dealService;
			_clientService = clientService;
			_realtorService = realtorService;
		}

		// GET: DealController
		public ActionResult Index()
		{
			var deals = _dealService.GetDeals();
			return View(deals);
		}

		// GET: DealController/Details/5
		public ActionResult Details(int id)
		{
			var deal = _dealService.GetById(id);
			return View(deal);
		}

		public IActionResult Create(int? id)
		{
			ViewBag.Clients = _clientService.GetAll()
				.OrderBy(_ => _.ToString());
			ViewBag.Realtors = _realtorService.GetAll()
				.OrderBy(_ => _.ToString());
			if (id == null)
				return View();
			var deal = _dealService.GetById(id.Value);
			return View(deal);
		}
		[HttpPost]
		public IActionResult Create(DealDto deal)
		{
			if (!ModelState.IsValid)
				return RedirectToAction(nameof(Create), new { id = deal.Id });
			var res = _dealService.CreateOrUpdate(deal);
			return RedirectToAction(nameof(Index), new { id = res.Id });
		}

		// GET: DealController/Delete/5
		public ActionResult Delete(int id)
		{
			_dealService.Delete(id);
			return RedirectToAction(nameof(Index));
		}
	}
}

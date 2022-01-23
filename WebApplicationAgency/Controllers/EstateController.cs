using Business.Interop.Data;
using Business.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebApplicationAgency.Controllers
{
	public class EstateController : Controller
	{
		private readonly IEstateService _estateService;
		private readonly IEstateTypeService _estateTypeService;
		private readonly IDealService _dealService;
		private readonly IClientService _clientService;
		private readonly IStreetService _streetService; 

		public EstateController(IStreetService streetService, IClientService clientService,IDealService dealService ,IEstateService estateService, IEstateTypeService estateTypeService)
		{
			_estateService = estateService;
			_estateTypeService = estateTypeService;
			_dealService = dealService;
			_clientService = clientService;
			_streetService = streetService;
		}

		// GET: EstateController
		public ActionResult Index()
		{
			var estates = _estateService.GetAll();
			return View(estates);
		}

		// GET: EstateController/Details/5
		public ActionResult Details(int id)
		{
			var estate = _estateService.GetById(id);
			return View(estate);
		}

		

		// GET: EstateController/Edit/5
		public IActionResult Create(int? id)
		{
			ViewBag.Streets = _streetService.GetAll()
				.OrderBy(_ => _.ToString());
			ViewBag.EstateTypes = _estateTypeService.GetAll()
				.OrderBy(_ => _.ToString());
			ViewBag.Clients = _clientService.GetAll()
				.OrderBy(_ => _.ToString());
			if (id == null)
				return View();
			var estate = _estateService.GetById(id.Value);
			return View(estate);
		}

		[HttpPost]
		public IActionResult Create(EstateDto estate)
		{
			if (!ModelState.IsValid)
				return RedirectToAction(nameof(Create), new { id = estate.Id });
			var res = _estateService.CreateOrUpdate(estate);
			return RedirectToAction(nameof(Index), new { id = res.Id });
		}

		// GET: EstateController/Delete/5
		public ActionResult Delete(int id)
		{
			_estateService.Delete(id);
			return RedirectToAction(nameof(Index));
		}
	}
}

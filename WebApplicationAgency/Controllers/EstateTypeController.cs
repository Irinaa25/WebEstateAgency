using Business.Interop.Data;
using Business.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAgency.Controllers
{
    public class EstateTypeController : Controller
	{
		private readonly IEstateTypeService _estateTypeService;

		public EstateTypeController(IEstateTypeService estateTypeService)
		{
			_estateTypeService = estateTypeService;
		}

		// GET: EstateTypeController
		public ActionResult Index()
		{
			var estateTypes = _estateTypeService.GetEstateTypes();
			return View(estateTypes);
		}

		// GET: EstateTypeController/Details/5
		public ActionResult Details(int id)
		{
			var estateType = _estateTypeService.GetById(id);
			return View(estateType);
		}


		// GET: EstateTypeController/Edit/5
		public IActionResult Create(int? id)
		{
			var estateType = _estateTypeService.GetById(id.Value);
			return View(estateType);
		}

		[HttpPost]
		public IActionResult Create(EstateTypeDto estateType)
		{
			if (!ModelState.IsValid)
				return RedirectToAction(nameof(Create), new { id = estateType.Id });
			var res = _estateTypeService.CreateOrUpdate(estateType);
			return RedirectToAction(nameof(Index), new { id = res.Id });
		}

		// GET: EstateTypeController/Delete/5
		public ActionResult Delete(int id)
		{
			_estateTypeService.Delete(id);
			return RedirectToAction(nameof(Index));
		}
	}
}

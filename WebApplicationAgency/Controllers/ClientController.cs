using Business.Interop.Data;
using Business.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebApplicationAgency.Controllers
{
    public class ClientController : Controller
	{
		private readonly IClientService _clientService;
		private readonly IDealService _dealService;

		public ClientController(IClientService clientService, IDealService dealService)
		{
			_clientService = clientService;
			_dealService = dealService;
		}

		// GET: ClientController
		public ActionResult Index()
		{
			var clients = _clientService.GetAll();

			return View(clients);
		}

		// GET: ClientController/Details/5
		public ActionResult Details(int id)
		{
			var client = _clientService.GetById(id);
			var deals = _dealService.GetAll().Where(e => e.ClientId == id);
			client.Deals = deals;
			return View(client);
		}



		// GET: ClientController/Edit/5
		public IActionResult Create(int? id)
		{
			ViewBag.Deals = _dealService.GetAll()
				.OrderBy(_ => _.ToString());
			if (id == null)
				return View();
			var client = _clientService.GetById(id.Value);
			return View(client);
		}

		[HttpPost]
		public IActionResult Create(ClientDto client)
		{
			if (!ModelState.IsValid)
				return RedirectToAction(nameof(Create), new { id = client.Id });
			var res = _clientService.CreateOrUpdate(client);
			return RedirectToAction(nameof(Index), new { id = res.Id });
		}

		// GET: ClientController/Delete/5
		public ActionResult Delete(int id)
		{
			var client = _clientService.GetById(id);
			var deals = _dealService.GetAll().Where(_ => _.ClientId == id);
			foreach (var d in deals)
				_dealService.Delete(d.Id);
			_clientService.Delete(id);

			return RedirectToAction(nameof(Index));
		}

	}
}


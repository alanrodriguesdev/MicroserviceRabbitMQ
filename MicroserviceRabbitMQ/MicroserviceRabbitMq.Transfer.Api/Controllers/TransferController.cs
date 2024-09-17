using MicroserviceRabbitMQ.Transfer.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceRabbitMQ.Transfer.Api.Controllers
{
    public class TransferController : Controller
    {
        private readonly ITransferService _transferService;
        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }
        // GET: TransferController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TransferController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TransferController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransferController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: TransferController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TransferController/Edit/5
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

        // GET: TransferController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TransferController/Delete/5
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

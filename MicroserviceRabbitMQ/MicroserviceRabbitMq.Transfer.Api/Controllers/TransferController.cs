using MicroserviceRabbitMQ.Transfer.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceRabbitMQ.Transfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : Controller
    {
        private readonly ITransferService _transferService;
        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return Ok(_transferService.GetTransferLogs());
        }
    }
}

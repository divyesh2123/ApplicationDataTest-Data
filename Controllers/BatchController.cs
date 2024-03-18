using ApplicatinTest.BussinessService.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationDataTest.Controllers
{
    public class BatchController : Controller
    {
        private readonly IBatchService _batchService;
        public BatchController(IBatchService userService)
        {
            _batchService = userService;
        }
        public IActionResult Index()
        {
            var d = _batchService.GetAll();
            return View(d);
        }
    }
}

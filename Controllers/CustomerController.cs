using ApplicatinTest.BussinessService.Interface;
using ApplicatinTest.Common;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationDataTest.Controllers
{
    public class CustomerController : Controller
    {
       

        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService userService)
        {
            _customerService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public  IActionResult GetData( DatatableRequest request)
        
        
        {

            return Json(  _customerService.GetData(request) );

        }
    }
}

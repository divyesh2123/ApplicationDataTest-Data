using ApplicatinTest.BussinessEnity;
using ApplicatinTest.BussinessService.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationDataTest.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUserService _userService;
        public EmployeeController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public async  Task<IActionResult> Index(UserViewModal userViewModal)
        {
            if (!ModelState.IsValid)
            {
                return View(userViewModal);
            }

           var  s = await _userService.AddUpdateUser(userViewModal);
            return RedirectToAction("Index");
        }
    }
}

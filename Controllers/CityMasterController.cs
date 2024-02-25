using ApplicatinTest.BussinessEnity;
using ApplicatinTest.BussinessService.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationDataTest.Controllers
{
    public class CityMasterController : Controller
    {

        private readonly ICityService _cityService;
        public CityMasterController(ICityService userService)
        {
            _cityService = userService;
        }

        public IActionResult Index()
        
        {
            return View();
        }

        public async Task<IActionResult> GetData()
        {
           
                return Json(new { data = await _cityService.GetAllCities() });
            
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
           
                return Json(new { success = await _cityService.RemoveCity(id), message = "Deleted Successfully" });
            
        }

        [HttpGet]
        public async Task<IActionResult> AddEditBatch(int id = 0)
        {
            if (id == 0)
                return View(new CityViewModal());
            else
            {
                
                    return View(await _cityService.GetCity(id));
                
            }

        }

        [HttpPost]
        public async Task<IActionResult> AddEditBatch(CityViewModal batchViewModal)
        {
            

           
                    return Json(new { success = await _cityService.AddUpdateCity(batchViewModal), message = "Saved Successfully" });
               
            


        }
    }
}

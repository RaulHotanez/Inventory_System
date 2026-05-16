using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{
    public class SalesOrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

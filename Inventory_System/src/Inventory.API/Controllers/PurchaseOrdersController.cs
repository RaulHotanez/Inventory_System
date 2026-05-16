using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{
    public class PurchaseOrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

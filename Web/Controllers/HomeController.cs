using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Business.Concrete;
using DataAccess.Concrete;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private InventoryManager _inventoryManager=new InventoryManager(new EfInventoryDal());
        StockManager _stockManager=new StockManager(new EfStockDal());

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var stcok = _stockManager.GetList();
            return View(stcok);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using QuestSymboleBonnesPratiques.Models;
using System.Reflection;

namespace QuestSymboleBonnesPratiques.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            List<Product> list = new List<Product>() {
            new Product(1, "Pomme", 3),
            new Product(2, "Poire", 5),
            new Product(3, "Abricot", 8),
            new Product(4, "Raisin", 6),
            new Product(5, "Tomate", 100000000)
            };

            String conclusion = String.Empty;
            Int32 sum = list.Sum(m => m.Amount);
            if (sum > 10000000)
            {
                conclusion = "You earn too much money";
            }
            else
            {
                conclusion = "You should ask for a salary raise";
            }

            return View("Index", conclusion);
        }
    }
}

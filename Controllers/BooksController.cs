using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using marthas_website.Models;

namespace marthas_website.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

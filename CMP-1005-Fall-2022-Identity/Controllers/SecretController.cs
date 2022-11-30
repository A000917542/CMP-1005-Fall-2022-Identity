using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CMP_1005_Fall_2022_Identity.Controllers
{
    [Authorize]
    public class SecretController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Info()
        {
            return View();
        }
    }
}

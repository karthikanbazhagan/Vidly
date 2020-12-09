namespace Vidly.Controllers
{
    using System.Web.Mvc;

    public class RentalsController : Controller
    {
        // GET: Rentals
        public ActionResult New()
        {
            return View();
        }
    }
}
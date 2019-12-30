namespace UnitTesting.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    /// Home Controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Default action method
        /// </summary>
        /// <returns>The action result</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Gives the description page of application
        /// </summary>
        /// <returns>The action result</returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// Gives the contact details page of application
        /// </summary>
        /// <returns>The action result</returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
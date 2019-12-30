namespace CustomRoute.Controllers
{
    using CustomRoute.Models;
    using System.Web.Mvc;

    /// <summary>
    /// Home Controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Default action method of controller.
        /// </summary>
        /// <returns>The action result.</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Gives the description of application.
        /// </summary>
        /// <returns>The action result.</returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// Gives the contact details of application.
        /// </summary>
        /// <returns>The action result.</returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /// <summary>
        /// Custom action method to create a custom route in RouteConfig.cs file.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The action result.</returns>
        public ActionResult Custom(int id)
        {
            var person = new PersonModel()
            {
                ID = id
            };
            return View(person);
        }
    }
}
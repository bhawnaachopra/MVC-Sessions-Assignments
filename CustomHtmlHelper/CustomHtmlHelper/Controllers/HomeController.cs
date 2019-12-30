namespace CustomHtmlHelper.Controllers
{
    using CustomHtmlHelper.Models;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        /// <summary>
        /// Action methos which gives the url path of image
        /// </summary>
        /// <returns>The action result</returns>
        public ActionResult Index()
        {
            var model = new ImageModel()
            {
                ImageUrl = "/Content/nagarro-image.JPG"
                //ImageUrl = WebConfigurationManager.AppSettings["ImageUrl"]
            };
            return View(model);
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
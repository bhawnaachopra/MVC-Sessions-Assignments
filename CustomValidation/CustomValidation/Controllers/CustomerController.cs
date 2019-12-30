namespace CustomValidation.Controllers
{
    using CustomValidation.Models;
    using System.Web.Mvc;

    /// <summary>
    /// Customer Controller
    /// </summary>
    public class CustomerController : Controller
    {
        /// <summary>
        /// Default action method of controller
        /// </summary>
        /// <returns>The action result</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Gets the customer
        /// </summary>
        /// <returns>The action result</returns>
        [HttpGet]
        public ActionResult Create()
        {
            var customer = new Customer();
            return View(customer);
        }

        /// <summary>
        /// Posts the customer 
        /// </summary>
        /// <param name="customer">Customer</param>
        /// <returns>The action result</returns>
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                return View(customer);
            }
            catch
            {
                return View();
            }

        }
    }
}
namespace UnitTesting.Tests.Controllers
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using UnitTesting.Controllers;
    using UnitTesting.Models;

    /// <summary>
    /// Test class to validate views and model properties
    /// </summary>
    [TestClass]
    public class HomeControllerTest
    {
        /// <summary>
        /// Checks the validation result
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns>Validation result</returns>
        private IList<ValidationResult> ValidateModel(object model)
        {
            var result = new List<ValidationResult>();
            var validationContext = new ValidationContext(model, null, null);
            Validator.TryValidateObject(model, validationContext, result, true);

            return result;
        }

        /// <summary>
        /// To verify the attributes on properties of employee model
        /// </summary>
        [TestMethod]
        public void ToVerifyEmployeeModelClassAttributes()
        {        
            var employee = new Employee
            {
                Id = "001",
                Name = "Bhawna",
                Age = 5
            };
            Assert.AreEqual(0, ValidateModel(employee).Count);
        }

        /// <summary>
        /// To verify the Index View of Home Controller
        /// </summary>
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            //Assert.IsNotNull(result);
        }

        /// <summary>
        /// To verify the About View of Home Controller
        /// </summary>
        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        /// <summary>
        /// To verify the Contact View of Home Controller
        /// </summary>
        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

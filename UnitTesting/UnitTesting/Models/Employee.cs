namespace UnitTesting.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// class for employee details
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets the Id of an employee
        /// </summary>
        [Required(ErrorMessage = "Employee Id should not be empty")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of an employee
        /// </summary>
        [Required(ErrorMessage = "Please enter your Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the age of an employee
        /// </summary>
        [Required]
        [Range(10, 50)]
        public int Age { get; set; }

        

        
    }
}
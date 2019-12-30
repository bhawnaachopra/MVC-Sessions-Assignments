namespace CustomValidation.Models
{
    using CustomValidation.ValidationAttributes;
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Class for customer details
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets Id of customer
        /// </summary>
        [Display(Name = "Customer Id")]
        [Required(ErrorMessage = "Customer Id is required")]
        public long CustomerId { get; set; }

        /// <summary>
        /// Gets or sets company name of customer
        /// </summary>
        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Company Name is required")]
        [StringLength(10, ErrorMessage = "Company Name should be less than or equal to ten characters")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets age of customer
        /// </summary>
        [Display(Name = "Age")]
        [Range(20, 40, ErrorMessage = "Customer Age should be between 20 and 40")]
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets birth date of customer
        /// </summary>
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [ValidBirthDate(ErrorMessage = "Birth Date can not be greater than current date")]
        public DateTime BirthDate { get; set; }

    }
}
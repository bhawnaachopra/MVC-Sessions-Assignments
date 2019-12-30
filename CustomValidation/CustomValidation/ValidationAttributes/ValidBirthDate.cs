namespace CustomValidation.ValidationAttributes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    /// <summary>
    /// ValidBirthDate class to implement server and client side validations
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class ValidBirthDate : ValidationAttribute, IClientValidatable
    {
        /// <summary>
        /// Method to perform server validation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="validationContext"></param>
        /// <returns>Validation Result</returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            
                if (Convert.ToDateTime(value) > DateTime.Now)
                {
                    return new ValidationResult("Birth Date can not be greater than current date");
                }
            
            return ValidationResult.Success;
        }
        
        /// <summary>
        /// To perform client validation
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="context"></param>
        /// <returns>The result</returns>
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            ModelClientValidationRule mvr = new ModelClientValidationRule();
            mvr.ErrorMessage = "Birth Date can not be greater than current date";
            mvr.ValidationType = "validbirthdate";
            return new[] { mvr };
        }
        
    }
}
namespace CustomRoute.Models
{
    using System;

    /// <summary>
    /// PersonModel class to get the details of a person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Gets or sets the Id of person
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Gets or sets the Name of person
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the Birth Date of person
        /// </summary>
        public DateTime DateOfBirth { get; set; }
    }
}
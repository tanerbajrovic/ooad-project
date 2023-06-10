using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace FitnessFusion.Models
{
    public class ApplicationUser : IdentityUser
    {
        #region Properties

        [Required]
        [StringLength(25, ErrorMessage = "First name cannot be longer than 25 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "First name cannot be longer than 25 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Address cannot be longer than 50 characters.")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        // [RegularExpression("[MF]", ErrorMessage = "Sex must be either 'M' or 'F'.")]
        public char Sex { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        #endregion

        #region Constructor

        public ApplicationUser() { }

        #endregion

        #region Methods
        
        // TODO

        #endregion
    }
}

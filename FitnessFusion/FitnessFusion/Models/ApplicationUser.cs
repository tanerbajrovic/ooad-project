using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class ApplicationUser : IdentityUser
    {
        #region Properties
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Address")]
        public string Address { get; set; }
        public char Sex { get; set; }
        [DisplayName("Date of Birth")]
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

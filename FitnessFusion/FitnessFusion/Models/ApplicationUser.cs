using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class ApplicationUser : IdentityUser
    {
        #region Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public char Sex { get; set; }
        public DateTime DateOfBirth { get; set; }

        // GymUser Properties
        [ForeignKey("GymProgram")]
        public int IDGymProgram { get; set; }
        public GymProgram GymProgram { get; set; }
        [NotMapped]
        public List<HealthIssueType> HealthIssues { get; set; }
        public double ActivityCoefficient { get; set; }

        // Trainer Properties
        public Experience Experience { get; set; }

        #endregion

        #region Constructor

        public ApplicationUser() { }

        #endregion

        #region Methods
        
        // TODO

        #endregion
    }
}

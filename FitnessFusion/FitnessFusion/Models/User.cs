using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class User : Person 
    {
        #region Properties
        [ForeignKey("GymProgram")]
        public int IDGymProgram { get; set; }
        public GymProgram GymProgram { get; set; }
        [NotMapped]
        public List<HealthIssueType> HealthIssues { get; set; }
        public double ActivityCoefficient { get; set; }

        #endregion

        #region Constructor

        public User() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}

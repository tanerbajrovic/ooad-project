using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class User : Person 
    {
        #region Properties

        // public List<HealthIssueType> HealthIssues { get; set
        public double ActivityCoefficient { get; set; }
        public Schedule Schedule { get; set; }
        public GymProgram ActivityProgram { get; set; }

        #endregion

        #region Constructor

        public User() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}

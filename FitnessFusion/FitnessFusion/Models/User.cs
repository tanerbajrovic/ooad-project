using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class User : Person 
    {
        #region Properties
        
        [NotMapped]
        public List<HealthIssueType> HealthIssues { get; set; }
        public double ActivityCoefficient { get; set; }
        [ForeignKey("Schedule")] // Not sure about this one?
        public int IDSchedule { get; set; }
        public Schedule Schedule { get; set; }
        [ForeignKey("GymProgram")]
        public int IDGymProgram { get; set; }
        public GymProgram GymProgram { get; set; }

        #endregion

        #region Constructor

        public User() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}

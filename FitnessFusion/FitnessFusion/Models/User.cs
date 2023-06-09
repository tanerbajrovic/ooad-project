using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class User : ApplicationUser
    {
        #region Properties

        [ForeignKey("GymProgram")]
        public int GymProgramId { get; set; }
        public GymProgram GymProgram { get; set; }
        [NotMapped]
        [Display(Name = "Health Issues")]
        public List<HealthIssueType> HealthIssues { get; set; } = new List<HealthIssueType>();
        [DisplayName("Activity Coefficient")]
        public double ActivityCoefficient { get; set; }

        #endregion

        #region Constructor

        public User() : base() { }

        #endregion

        #region

        // TODO

        #endregion
    }
}

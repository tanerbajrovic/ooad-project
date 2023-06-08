using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class User
    {
        #region Properties
        [Key]
        public int Id { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [DisplayName("Gym Program")]
        [ForeignKey("GymProgram")]
        public int GymProgramId { get; set; }
        public GymProgram GymProgram { get; set; }
        [NotMapped]
        public List<HealthIssueType> HealthIssues { get; set; }
        [DisplayName("Activity Coefficient")]
        [Range(1, 6, ErrorMessage = "Activity coefficient must be between 1 and 6.")]
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

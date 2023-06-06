using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class GymActivityChoice
    {
        #region Properties

        [Key]
        public int Id {  get; set; }
        [ForeignKey("Training")]
        public int? TrainingId { get; set; }
        public Training Training { get; set; }
        [ForeignKey("ExtraGymSession")]
        public int? ExtraGymSessionId { get; set; }
        public ExtraGymSession ExtraGymSession { get; set; }
        [ForeignKey("GymActivity")]
        public int GymActivityId { get; set; }
        public GymActivity GymActivity { get; set; }

        #endregion

        #region Constructor

        public GymActivityChoice() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}

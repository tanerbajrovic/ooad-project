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

        // extraID is provided when clone method is called from ExtraGymSession class, and trainingID when called from Training class
        public GymActivityChoice clone(GymActivityChoice original, int extraID=-1, int trainingID=-1)
        {
            TrainingId = original.TrainingId;
            Training = original.Training;
            if(extraID!=-1)
            {
                ExtraGymSessionId = extraID;
            }
            else
            {
                TrainingId = trainingID;
            }
            GymActivityId = original.GymActivityId;
            return this;
        }

        #endregion
    }
}

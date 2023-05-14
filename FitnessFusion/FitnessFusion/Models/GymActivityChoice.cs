using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class GymActivityChoice
    {
        #region Properties

        [Key]
        public int ID {  get; set; }
        [ForeignKey("GymSession")]
        public int GymSessionID { get; set; }
        [ForeignKey("GymActivity")]
        public int GymActivityID { get; set; }

        // Also include GymSession and GymActivity objects?

        #endregion

        #region Constructor

        public GymActivityChoice(int id, int gymSessionId, int gymActivityId)
        {
            ID = id;
            GymSessionID = gymSessionId;
            GymActivityID = gymActivityId;
        }

        public GymActivityChoice() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}

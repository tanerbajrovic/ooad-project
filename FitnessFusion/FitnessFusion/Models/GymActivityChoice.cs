using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class GymActivityChoice
    {
        #region Properties

        [Key]
        public int ID {  get; set; }
        [ForeignKey("Training")]
        public int? IDTraining { get; set; }
        public Training Training { get; set; }
        [ForeignKey("ExtraGymSession")]
        public int? IDExtraGymSession { get; set; }
        public ExtraGymSession ExtraGymSession { get; set; }
        [ForeignKey("GymActivity")]
        public int IDGymActivity { get; set; }
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

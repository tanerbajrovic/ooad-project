using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class Rating
    {
        #region Properties

        [Key]
        public int Id { get; set; }
        [ForeignKey("GymProgram")]
        public int GymProgramId { get; set; }
        public GymProgram GymProgram { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User User { get; set; }
        [DisplayName("Rating Value")]
        public double RatingValue { get; set; }
        public string Review { get; set; }

        #endregion

        #region Constructor

        public Rating () { }

        #endregion

        #region Methods

        // TODO

        #endregion 
    }
}

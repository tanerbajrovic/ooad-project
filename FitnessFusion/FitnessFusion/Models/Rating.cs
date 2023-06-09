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
        public string UserId { get; set; }
        public User User { get; set; }
        [DisplayName("Rating Value")]
        [Range(0, 5.0)]
        public double RatingValue { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Review cannot be longer than 100 characters.")]
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

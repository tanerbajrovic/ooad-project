using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class GymActivity
    {
        #region Properties

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Activity name cannot be longer than 50 characters.")]
        public string Name { get; set; }
        [DisplayName("Difficulty Level")]
        [Range(1, 5, ErrorMessage = "Difficulty level is from 1 to 5.")]
        public int DifficultyLevel { get; set; }

        #endregion

        #region Constructor

        public GymActivity() { }
        
        #endregion

        #region Methods

        // TODO

        #endregion
    }
}

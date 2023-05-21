using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class GymActivity
    {
        #region Properties

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
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

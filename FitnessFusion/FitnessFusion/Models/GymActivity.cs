using System.ComponentModel.DataAnnotations;

namespace FitnessFusion.Models
{
    public class GymActivity
    {
        #region Properties

        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public int DifficultyLevel { get; set; }

        #endregion

        #region Constructor

        public GymActivity(string id, string name, int difficultyLevel)
        {
            ID = id;
            Name = name;
            DifficultyLevel = difficultyLevel;
        }

        public GymActivity() { }
        
        #endregion

        #region Methods

        // TODO

        #endregion
    }
}

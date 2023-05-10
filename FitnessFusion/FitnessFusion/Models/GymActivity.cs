namespace FitnessFusion.Models
{
    public class GymActivity
    {
        #region Attributes

        private string id;
        private string name;
        private int difficultyLevel;

        #endregion Attributes

        #region Properties

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int DifficultyLevel { get => difficultyLevel; set => difficultyLevel = value; }

        #endregion

        #region Constructor

        public GymActivity(string id, string name, int difficultyLevel)
        {
            Id = id;
            Name = name;
            DifficultyLevel = difficultyLevel;
        }

        public GymActivity()
        {

        }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}

namespace FitnessFusion.Models
{
    public class Activity
    {
        #region Attributes
        
        private string id;
        private string name;
        private string type;
        private int difficultyLevel;

        #endregion Attributes

        #region Properties

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int DifficultyLevel { get => difficultyLevel; set => difficultyLevel = value; }

        #endregion

        #region Constructor

        public Activity(string id, string name, int difficultyLevel)
        {
            Id = id;
            Name = name;
            DifficultyLevel = difficultyLevel;
        }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}

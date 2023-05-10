using System.Collections.Generic;

namespace FitnessFusion.Models
{
    public class GymProgram
    {
        #region Attributes

        private int id;
        private string name;
        private string overview;
        private string description;
        private List<Training> trainings;
        private List<Category> categories;
        private List<Rating> ratings;

        #endregion

        #region Properties
        public int Id { get =>  id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Overview { get => overview; set => overview = value; }
        public List<Category> Categories { get => categories; set => categories = value; }
        public List<Training> Trainings { get => trainings; set => trainings = value; }
        public List<Rating> Ratings { get => ratings; set => ratings = value; }

        #endregion

        #region Constructor
        public GymProgram(int id, string name, string description, string overview,
                               List<Training> trainings, List<Category> categories,
                               List<Rating> ratings)
        {
            Id = id;
            Name = name;
            Overview = overview;
            Description = description;
            Trainings = trainings;
            Categories = categories;
            Ratings = ratings;
        }

        public GymProgram()
        {

        }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessFusion.Models
{
    public class GymProgram
    {
        #region Properties

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Overview { get; set; }
        public GymProgramType Type { get; set; }
        public List<Training> Trainings { get; set; }
        public List<Rating> Ratings { get; set; }

        #endregion

        #region Constructor

        public GymProgram(int id, string name, string description, string overview,
           GymProgramType type, List<Training> trainings, List<Rating> ratings)
        {
            ID = id;
            Name = name;
            Description = description;
            Overview = overview;
            Type = type;
            Trainings = trainings;
            Ratings = ratings;
        }

        public GymProgram() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
